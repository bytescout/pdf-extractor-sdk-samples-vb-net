'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Namespace ConsoleApplication1

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.JSONExtractor instance
            Dim extractor As New JSONExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            extractor.SaveJSONToFile("output.json")

            ' Cleanup
		    extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.json' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open JSON file in default viewer...")
            Console.ReadKey()

            ' Open result file in default associated application (for demo purposes)
            Process.Start("output.json")

        End Sub

    End Class
    
End Namespace

