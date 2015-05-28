# WorklistViewer
Just a simple Dicom Worklist querier.

Well, this is a little tool that just query a Dicom Worklist and shows the results.
It shows every single study present on your worklist, filtered by any kind of the following data you want:

- Study date (Fecha)
- Patient ID (DNI)
- Patient Name (Nombre)
- Accession Number (Acc. no. / N° Acceso)

It accepts wildcards, * and %, at the begining or at the end of the entered data (not in the middle).
E.g.: "Peter*" or "*Capusotto" to search for "Peter Capusotto".
The same works with number fields.
You can fill any combination of those fields simoultaneously to narrow the search.

It's GUI is still in spanish (sorry about that) but code is entirely in english (and C#) language.

Worklist server data and local AETitle is configured by "config.txt", expected in the same folder as .exe file, an example is shipped in the project root folder.

It runs on .net framework 4.0 for compatibility with so old Windows XP version.
Icon is made by me on GIMP in full 256px resolution.
Apparently it doesn't work well on XP on that res, so I would compile it twice: once with the 64px ".ico" icon, and after redo it again with the full res ico for any other Windows version.

It's a super-ultra-mega-customized tool made for my job, so it might not work on your environment.
You will need RZDCX.dll installed on your PC before starting the application, you can find it here:
[http://downloads.roniza.com/rzdcx/2.0.5.0/]
All credits to H.R.Z. Software, please visit it's homesite: [http://www.roniza.com/]
They let you download a "shareware" dll that works fine for 100 transactions, then you have to restart it (a sign shows up saying that library is demo). It's more than enough for lots of worklist queries, don't worry.
Once you have the file, then you must execute regsvr32.exe with the dll path as parameter (like "regsvr32 C:\rzdcx.dll") as administrator.

If you need help, want to hire me, or may be eat pizza with me, you're welcome! :)
