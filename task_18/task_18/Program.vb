Module Program
	Sub Main()
		Dim menu_input As String
		Dim fileread As IO.StreamReader,filewrite As IO.StreamWriter
		Console.WriteLine("menu for car management")
		Console.Write("1.Create car sales file" & vbCrLf & "2.Search by registration" & vbCrLf & "3.Repairs report" & vbCrLf & "4.Add new car sales" & vbCrLf & "5.Exit" & vbCrLf)
		menu_input=Console.ReadLine()
		While menu_input <> ""
			If menu_input="1" Then
				filewrite=New IO.StreamWriter("CARSALE.txt",True)
				filewrite.Close()
			ElseIf menu_input="2" Then
				Dim s_input As String,s_flag As Boolean=False,f_get As String
				s_input=Console.ReadLine()
				fileread=New IO.StreamReader("CARSALE.txt")
				f_get=fileread.ReadLine()
				While f_get <> ""
					If f_get=s_input Then
						Console.WriteLine(f_get)
						f_get=fileread.ReadLine()
						Console.WriteLine(f_get)
						f_get=fileread.ReadLine()
						Console.WriteLine(f_get)
						s_flag=True
					End If
					f_get=fileread.ReadLine()
				End While
				If s_flag=False Then
					Console.WriteLine("No car found")
				End If
				fileread.Close()
			ElseIf menu_input="3" Then
				Dim fileget As String
				fileread=New IO.StreamReader("CARSALE.txt")
				fileget=fileread.ReadLine()
				While fileget<> ""
					Console.WriteLine(fileget)
					fileget=fileread.ReadLine()
				End While
				fileread.Close()
			Else If menu_input="4" Then
				Dim input1 As String,input2 As String,input3 As String
				input1=Console.ReadLine()
				input2=Console.ReadLine()
				input3=Console.ReadLine()
				filewrite=New IO.StreamWriter("CARSALE.txt",True)
				filewrite.WriteLine(input1)
				filewrite.WriteLine(input2)
				filewrite.WriteLine(input3)
				filewrite.Close()
			Else If menu_input="5" Then
				Exit Sub
			Else
				Console.WriteLine("no correct choice")
			End If
			menu_input=Console.ReadLine()
		End While
		Console.ReadKey(True)
	End Sub
End Module
