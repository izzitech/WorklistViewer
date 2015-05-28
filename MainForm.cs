using rzdcxLib;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WorklistViewer
{
    public partial class MainForm : Form
    {
        Config config = new Config();
        DataTable dataTable = new DataTable();

        class fecha
        {
            ushort _year;
            public ushort year
            { get { return _year; } }
            
            ushort _month;
            public ushort month
            { get { return _month; } }
            
            ushort _day;
            public ushort day
            { get { return _day; } }

            public fecha(string value)
            {
                _year = ushort.Parse(value.Substring(0, 4));
                _month = ushort.Parse(value.Substring(4, 2));
                _day = ushort.Parse(value.Substring(6, 2));
            }
        }

        class time
        {
            ushort _hour;
            public ushort hour
            { get { return _hour; } }

            ushort _minutes;
            public ushort minutes
            { get { return _minutes; } }

            ushort _seconds;
            public ushort seconds
            { get { return _seconds; } }

            public time(string value)
            {
                _hour = ushort.Parse(value.Substring(0, 2));
                _minutes = ushort.Parse(value.Substring(2, 2));
                _seconds = ushort.Parse(value.Substring(4, 2));
            }
        }

        public MainForm()
        {
            InitializeComponent();
            config.Read();

            System.Diagnostics.Debug.WriteLine(config.serverIp);
            System.Diagnostics.Debug.WriteLine(config.serverPort);
            System.Diagnostics.Debug.WriteLine(config.targetAETitle);
            System.Diagnostics.Debug.WriteLine(config.localAETitle);

            Query();
        }

        /* Callback when a response from the called ae for the query command is recieved */
        public void OnQueryResponseRecievedAction(DCXOBJ obj)
        {
            // Do something
            ReleaseComObject(obj);
        }

        /* Callback when a response from the called ae for the move command is recieved */
        public void OnMoveResponseRecievedAction(bool status, DCXOBJ obj)
        {
            // Do something
            ReleaseComObject(obj);
        }

        private string TryGetString(DCXOBJ obj, DICOM_TAGS_ENUM tag)
        {
            try
            {
                DCXELM e = obj.getElementByTag((int)tag);
                if (e != null && e.Value != null)
                    return obj.getElementByTag((int)tag).Value.ToString();
                else
                    return "N/A";
            }
            catch (COMException)
            {
                return "N/A";
            }
        }

        private void LoadResultsToGrid(DCXOBJIterator it)
        {
            DCXOBJ currObj = null;

            try
            {
                DataTable rq = new DataTable("RQ");
                DataRow rqRow;

                rq.Columns.Add(new DataColumn("Accession Number", typeof(string)));
                rq.Columns.Add(new DataColumn("Patient ID", typeof(string)));
                rq.Columns.Add(new DataColumn("Patient Name", typeof(string)));
                rq.Columns.Add(new DataColumn("Patient BirthDate", typeof(string)));
                rq.Columns.Add(new DataColumn("Patient Sex", typeof(string)));
                rq.Columns.Add(new DataColumn("Patient Weight", typeof(string)));
                rq.Columns.Add(new DataColumn("Modality", typeof(string)));
                rq.Columns.Add(new DataColumn("Fecha", typeof(string)));
                rq.Columns.Add(new DataColumn("Time", typeof(string)));
                //rq.Columns.Add(new DataColumn("Physician Reading Study", typeof(string)));
                rq.Columns.Add(new DataColumn("Referring Physician", typeof(string)));

                // Iterate over the query results
                for (; !it.AtEnd(); it.Next())
                {
                    currObj = it.Get();
                    rqRow = rq.NewRow();
                    rqRow["Accession Number"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.AccessionNumber);
                    rqRow["Patient ID"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.patientID);
                    rqRow["Patient Name"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.patientName);
                    rqRow["Patient BirthDate"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.PatientBirthDate);
                    rqRow["Patient Sex"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.PatientSex);
                    rqRow["Patient Weight"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.PatientsWeight);
                    rqRow["Modality"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.Modality);
                    rqRow["Fecha"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.ScheduledProcedureStepStartDate);
                    rqRow["Time"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.ScheduledProcedureStepStartTime);
                    rqRow["Referring Physician"] =
                        TryGetString(currObj, DICOM_TAGS_ENUM.ReferringPhysicianName);

                    rq.Rows.Add(rqRow);
                }

                dataTable = rq;

                //// Bind the master data connector 

                RefrescarDataGrid();
            }
            finally
            {
                ReleaseComObject(currObj);
            }

        }

        public void Query()
        {
            DCXOBJIterator it = null;
            DCXREQ req = new DCXREQClass();
            DCXOBJ rp = new DCXOBJ();
            DCXELM el = new DCXELM();

            try
            {
                //el.Init((int)DICOM_TAGS_ENUM.studyInstanceUID);
                //rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.AccessionNumber);
                // el.Value = "34*";
                rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.PatientsName);
                rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.patientID);
                rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.PatientBirthDate);
                rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.PatientSex);
                rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.PatientsWeight);
                rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.Modality);
                rp.insertElement(el);

                // A lot of code to handle all the cases of date and time matching
                // that eventually goes into the elements: ScheduledProcedureStepStartDate and ScheduledProcedureStepStartTime
                el.Init((int)DICOM_TAGS_ENUM.ScheduledProcedureStepSequence);
                rp.insertElement(el);

                //el.Init((int)DICOM_TAGS_ENUM.ScheduledProcedureStepStartDate);
                //rp.insertElement(el);

                //el.Init((int)DICOM_TAGS_ENUM.NameOfPhysiciansReadingStudy);
                //rp.insertElement(el);

                el.Init((int)DICOM_TAGS_ENUM.ReferringPhysicianName);
                rp.insertElement(el);

                // Connect the requester object's callback to our method
                req.OnQueryResponseRecieved += new IDCXREQEvents_OnQueryResponseRecievedEventHandler(OnQueryResponseRecievedAction);

                rp.Dump("query.txt");

                // send the query command
                it = req.Query(config.localAETitle,
                               config.targetAETitle,
                               config.serverIp,
                               config.serverPort,
                               "1.2.840.10008.5.1.4.31",  /// Modality Worklist SOP Class
                               rp);

                LoadResultsToGrid(it);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Query failed: " + ex.Message);
            }
            finally
            {
                ReleaseComObject(req);
                ReleaseComObject(rp);
                ReleaseComObject(it);
                ReleaseComObject(el);
            }
        }

        /* This has to be called for all the com objects to release the memory!!! */
        private void ReleaseComObject(object o)
        {
            if (o != null)
                Marshal.ReleaseComObject(o);
        }

        private void dgvWorklist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (((DataGridView)sender).SelectedRows.Count > 0)
                {
                    tbDNI.Text =
                        ((DataGridView)sender).SelectedRows[0].Cells["Patient ID"].Value.ToString();
                    tbNombre.Text =
                        ((DataGridView)sender).SelectedRows[0].Cells["Patient Name"].Value.ToString();

                    fecha birthdateValue = new fecha(((DataGridView)sender).SelectedRows[0].Cells["Patient BirthDate"].Value.ToString());
                    dtNacimiento.Value = new DateTime(birthdateValue.year, birthdateValue.month, birthdateValue.day);

                    if (((DataGridView)sender).SelectedRows[0].Cells["Patient Sex"].Value.ToString() == "M")
                        rbMasculino.Checked = true;
                    else if (((DataGridView)sender).SelectedRows[0].Cells["Patient Sex"].Value.ToString() == "F")
                        rbFemenino.Checked = true;
                    else
                        rbNSNC.Checked = true;

                    tbPeso.Text =
                        ((DataGridView)sender).SelectedRows[0].Cells["Patient Weight"].Value.ToString();
                    tbAccessionNumber.Text =
                        ((DataGridView)sender).SelectedRows[0].Cells["Accession Number"].Value.ToString();
                    tbModalidad.Text =
                        ((DataGridView)sender).SelectedRows[0].Cells["Modality"].Value.ToString();

                    System.Diagnostics.Debug.WriteLine(((DataGridView)sender).SelectedRows[0].Cells["Fecha"].Value.ToString());
                    
                    fecha fechaStudy = new fecha(((DataGridView)sender).SelectedRows[0].Cells["Fecha"].Value.ToString());
                    dtFecha.Value = new DateTime(fechaStudy.year, fechaStudy.month, fechaStudy.day);

                    time studyTime = new time(((DataGridView)sender).SelectedRows[0].Cells["Time"].Value.ToString());
                    nHora.Value = studyTime.hour;
                    nMinutos.Value = studyTime.minutes;

                    //tbMedico.Text =
                    //    ((DataGridView)sender).SelectedRows[0].Cells["Physician Reading Study"].Value.ToString();
                    tbReferente.Text =
                        ((DataGridView)sender).SelectedRows[0].Cells["Referring Physician"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error al copiar los datos del Worklist a los campos locales:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }

        private void RefrescarDataGrid()
        {
            string filter = "(([Fecha] LIKE \'" + dateTimePicker1.Value.Year + dateTimePicker1.Value.Month.ToString("00") + dateTimePicker1.Value.Day.ToString("00") + "\') " +
                            "AND (([Accession number] LIKE \'" + tbAccNumFilter.Text + "\') " +
                            "AND (([Patient ID] LIKE \'" + tbDNIFilter.Text + "\') " +
                            "AND ([Patient Name] LIKE \'" + tbNameFilter.Text + "\'))))";

            System.Diagnostics.Debug.WriteLine(filter);

            DataView dv = new DataView(dataTable);
            dv.RowFilter = filter;
            dgvWorklist.DataSource = dv;

            dgvWorklist.Columns["Accession number"].HeaderText = "N° de acceso";
            dgvWorklist.Columns["Patient ID"].HeaderText = "DNI";
            dgvWorklist.Columns["Patient Name"].HeaderText = "Paciente";

            dgvWorklist.Columns["Accession number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWorklist.Columns["Patient ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvWorklist.Columns["Patient Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvWorklist.Columns["Patient BirthDate"].Visible = false;
            dgvWorklist.Columns["Patient Sex"].Visible = false;
            dgvWorklist.Columns["Patient Weight"].Visible = false;
            dgvWorklist.Columns["Modality"].Visible = false;
            dgvWorklist.Columns["Fecha"].Visible = false;
            dgvWorklist.Columns["Time"].Visible = false;
            //dgvWorklist.Columns["Physician Reading Study"].Visible = false;
            dgvWorklist.Columns["Referring Physician"].Visible = false;

            dgvWorklist.AutoResizeColumns();
        }

        private void dtNacimiento_ValueChanged(object sender, EventArgs e)
        {
            tbEdad.Text = Utils.AgeCalc(dtNacimiento.Value).ToString();
        }

        private void tbDNIFilter_TextChanged(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }

        private void tbNameFilter_TextChanged(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }

        private void tbAccNumFilter_TextChanged(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }
    }
}
