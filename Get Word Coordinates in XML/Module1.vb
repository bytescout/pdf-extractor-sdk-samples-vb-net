'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Namespace PDF2XML

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.XMLExtractor instance
            Dim extractor As New XMLExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            ' Add the following params to get clean data with word nodes only
            extractor.DetectNewColumnBySpacesRatio = 0.1  ' this splits all text into words
            extractor.PreserveFormattingOnTextExtraction = False  ' Get rid Of empty nodes

            extractor.SaveXMLToFile("output.XML")

            ' Cleanup
            extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.XML' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key...")
            Console.ReadKey()

        End Sub

    End Class

End Namespace

