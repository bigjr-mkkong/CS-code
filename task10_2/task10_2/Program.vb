Module Program
	Sub Main()
		Dim input As String="default",cnt As Integer=0
		Console.WriteLine("please enter your strings and press enter, when you wish to quit, just press the enter key")
		While input.Length>0
			input=Console.ReadLine()
			cnt+=input.Length
		End While
		Console.WriteLine("you entered " & cnt & " character(s)")
		Console.ReadKey(True)
	End Sub
End Module
