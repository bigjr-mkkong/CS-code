Module Program
	Sub Main()
		Dim filewriter As IO.StreamWriter,input As String
		filewriter=New IO.StreamWriter("test.txt",True)
		input=Console.ReadLine()
		While input <> "###"
			filewriter.WriteLine(input)
			input=Console.ReadLine()
		End While
		filewriter.Close()
		Console.ReadKey(True)
	End Sub
End Module
