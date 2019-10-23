Module Program
	Sub Main()
		Dim n As String
		n=Console.ReadLine()
		While n <> ""
			For i As Integer = 1 To Math.Sqrt(Int(n))+1
				If n Mod i =0 Then
					Console.WriteLine(i & " " & n/i)
				End If
			Next i
			n=Console.ReadLine()
		End While
		Console.ReadKey(True)
	End Sub
End Module
