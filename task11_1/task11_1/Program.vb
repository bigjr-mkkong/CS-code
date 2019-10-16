Module Program
	Sub Main()
		Dim input As String, maxstr As String, maxlen As Integer =-1
		Console.WriteLine("please enter your strings and press enter, when you wish to quit, just press the enter key")
		input=Console.ReadLine()
		While input.Length>0
			If input.Length>=maxlen Then
				maxlen=input.Length
				maxstr=input
			End If
			input=Console.ReadLine()
		End While
		If maxlen>-1 Then
			Console.WriteLine("the longest string was " & maxstr & " with a length of " & maxlen)
		Else
			Console.WriteLine("you didn't enter anything...")
		End If
		Console.ReadKey(True)
	End Sub
End Module
