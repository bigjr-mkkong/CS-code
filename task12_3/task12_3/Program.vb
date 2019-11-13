Module Program
	Sub Main()
		Dim input As String, bd1 As String="Aaa000",bd2 As String="Zzz999",flag As Boolean=False
		While flag=False
			Console.WriteLine("please enter your name:")
			input=Console.ReadLine()
			If Len(input) <> 6 Then
				flag=False
				Console.WriteLine("wrong format")
			Else
				flag=True
				For i As Integer = 0 To 5
					If Asc(input(i))<Asc(bd1(i)) or Asc(input(i))>Asc(bd2(i)) Then
						flag=False
						Console.WriteLine("wrong format")
					End If
				Next i
			End If
		End While
		Console.WriteLine("you are right!")
		
		Console.ReadKey(True)
	End Sub
End Module
