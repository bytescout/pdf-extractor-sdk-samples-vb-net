'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())

		' Create Bytescout.PDFExtractor.TextExtractor instance
		Dim extractor As New TextExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
		extractor.LoadDocumentFromFile(".\sample2.pdf")

		' Get page count
		Dim pageCount As Integer = extractor.GetPageCount()

		For i As Integer = 0 To pageCount - 1
			Dim fileName As String = "page" & i & ".txt"

			' Save extracted page text to file
			extractor.SavePageTextToFile(i, fileName)
		Next

		' Cleanup
		extractor.Dispose()

		' Open result file in default associated application (for demo purposes)
		System.Diagnostics.Process.Start(".\page1.txt")
		
	End Sub
End Class
