'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


Imports Bytescout.PDFExtractor

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim searchablePdfMaker As SearchablePDFMaker = New SearchablePDFMaker()
        searchablePdfMaker.RegistrationName = "demo"
        searchablePdfMaker.RegistrationKey = "demo"

        ' Load sample PDF document
        searchablePdfMaker.LoadDocumentFromFile("sample_ocr.pdf")

        ' Set the location of "tessdata" folder containing language data files
        searchablePdfMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\"

        ' Set OCR language
        searchablePdfMaker.OCRLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata

        ' Set PDF document rendering resolution
        searchablePdfMaker.OCRResolution = 300

        ' Save extracted text to file
        searchablePdfMaker.MakePDFSearchable("output.pdf")

        searchablePDFMaker.Dispose()

        ' Open output file in default associated application
        System.Diagnostics.Process.Start("output.pdf")

    End Sub

End Module
