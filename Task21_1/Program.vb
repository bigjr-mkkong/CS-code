Module Program
'record in test.txt and seperate with "|"	
	Dim arr(1000,4) As String, vis(1000) As Integer,ubnd As Integer
	Sub read()'read the data in txt, always put at the top of the program
		Dim f_reader =New IO.StreamReader("test.txt")
		Dim pt As Integer=1,tmp As String()
		While Not f_reader.EndOfStream
			tmp=f_reader.ReadLine().Split("|")
			For i As Integer = 1 To 4
				arr(pt,i)=tmp(i-1)
			Next i
			vis(pt)=1
			pt+=1
		End While
		ubnd=pt-1
		f_reader.Close()
	End Sub
	
	Sub regist()'restord the record in the txt file, always put at the end of the program
		Dim f_writer=New IO.StreamWriter("test.txt")
		Dim pt As Integer=1
		For i As Integer = 1 To ubnd
			If vis(i)=1 Then
				For j As Integer = 1 To 4
				f_writer.Write(arr(i,j) & "|")
			    Next j
			    f_writer.WriteLine()
			End If
		Next i
		f_writer.Close()
	End Sub
	
	Function add(ByVal s As String) As Integer'input a string like: "kkk|www|???|????", return the upperbound of the record
		Dim inp As String()
		ubnd+=1
		inp=s.Split("|")
		For i As Integer = 1 To 4
			arr(ubnd,i)=inp(i-1)
		Next i
		vis(ubnd)=1
		Return ubnd
	End Function
	
	Function find(ByVal pren As String,ByVal subn As String) As Integer'input the first name and family name, return the position of the record (-1 means no this record)
		For i As Integer = 1 To ubnd
			If arr(i,1)=pren And arr(i,2)=subn And vis(i)=1 Then
				Return i
			End If
		Next i
		Return -1
	End Function
	
	Function del(ByVal pren As String,ByVal subn As String) As Integer'input the first name and family name of record, return==-1?cannot find the record:delete successfully
		Dim pos As Integer=find(pren,subn)
		If pos=-1 Then
			Return pos
		End If
		vis(pos)=0
		return 1
	End Function
	
	Function printReg(ByVal pos) As Integer'input a position of record, return=-1 means cannot find the record, return 1 means successfully print
		If vis(pos)=0 Then
			Console.WriteLine("cannot find the file")
			Return -1
		End If
		For i As Integer = 1 To 4
			Console.Write(arr(pos,i) & " ")
		Next i
		Console.WriteLine()
		Return 1
	End Function
	
	Sub Main()
		read()
		Dim opt As String
		While True
			Console.WriteLine("choose an operation:")
		Console.WriteLine("1. add new record")
		Console.WriteLine("2. find record")
		Console.WriteLine("3. delete record")
		Console.WriteLine("4. save")
		Console.WriteLine("5. exit")
			opt=Console.ReadLine()
		Select Case opt
			Case "1"
				Dim tmp1 As String
				Console.WriteLine("please type in this form: firstname|familyname|score|tele")
				tmp1=Console.ReadLine()
				add(tmp1)
			Case "2"
				Dim fin As String,fan As String
				Console.WriteLine("please enter the firstname")
				fin=Console.ReadLine()
				Console.WriteLine("please enter the familyname")
				fan=Console.ReadLine()
				printReg(find(fin,fan))
				Console.ReadLine()
			Case "3"
				Dim fin As String,fan As String
				Console.WriteLine("please enter the firstname")
				fin=Console.ReadLine()
				Console.WriteLine("please enter the familyname")
				fan=Console.ReadLine()
				del(fin,fan)
			Case "4"
				regist()
			Case "5"
				Console.WriteLine("make sure you already save the modifiled record(Y/N)")
				Dim tmp2 As String
				tmp2=Console.ReadLine()
				If Not tmp2="Y" Then
					Continue While
				End If
				Exit Sub
		End Select
		Console.Clear()
		End While
		Console.ReadKey(True)
	End Sub
End Module