Module Program
	Sub Main()
		Dim f_read As IO.StreamReader,name As String, psw As String,tmp As String
		While True
			f_read=New IO.StreamReader("reg.txt")
			Console.WriteLine("please enter the usernmae")
			name=Console.ReadLine()
			Console.WriteLine("please enter the password")
			psw=Console.ReadLine()
			While not f_read.EndOfStream=True
				tmp=f_read.ReadLine()
				If tmp=name Then
					If f_read.ReadLine()=psw Then
						Console.WriteLine("matched")
						Console.ReadKey(True)
						Exit Sub
					End If
					Console.WriteLine("password not matched")
					Console.ReadKey(True)
					Exit Sub
				End If
			End While
			Console.WriteLine("username not matched")
			Console.ReadKey(True)
			Console.Clear()
		End While
		Console.ReadKey(True)
	End Sub
End Module
