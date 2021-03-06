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

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.UnsearchablePDFMaker instance
        Dim unsearchablePDFMaker = New UnsearchablePDFMaker()
        unsearchablePDFMaker.RegistrationName = "demo"
        unsearchablePDFMaker.RegistrationKey = "demo"

        ' Load sample PDF document
        unsearchablePDFMaker.LoadDocumentFromFile("sample1.pdf")

        'maker.ImageFormat = EmbeddedImageFormat.JPEG; ' use JPEG for smaller PDF file, but be ready to compression artefacts
        'maker.JPEGQuality = 75; // JPEG quality (1 - 100)
        unsearchablePDFMaker.RenderingResolution = 300  ' larger resolution - longer processing And larger PDF file size

        ' Enable Black And White mode
        unsearchablePDFMaker.Grayscale = True

        ' Process the document
        unsearchablePDFMaker.MakePDFUnsearchable("result.pdf")

        ' Cleanup
        unsearchablePDFMaker.Dispose()

        ' Open the result PDF file in default associated application
        System.Diagnostics.Process.Start("result.pdf")

    End Sub

End Module
