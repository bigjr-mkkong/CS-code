Module Program
	Function chk_name(byval name As String) As Boolean
		For i As Integer = 0 To name.Length-1
			If Char.IsLetter(name(i))=false Then
				return false
			End If
		Next i
		return true
	End Function
	
	Function chk_dob(ByVal data As Date) As Boolean
		If data.Year>"2003" Or data.Month=vbNullString Or data.Day=vbNullString Then
			Return False
		End If
		Return True
	End Function
	
	Function chk_email(ByVal eml As String) As Boolean
		If eml.Contains("@")=False Then
			Return False
		Else If eml(0)="@" Or Right(eml,3).Contains("@") Then
			Return False
		End If
		return True
	End Function
	
	Sub Main()
		Dim filewriter As IO.StreamWriter
		filewriter=New IO.StreamWriter("reg.txt",True)
		Dim name As String,eml As String
		Dim dob As Date
		While True
			name=Console.ReadLine()
		While chk_name(name)=False
			Console.WriteLine("please try again")
			name=Console.ReadLine()
		End While
		filewriter.WriteLine(name)
		'Console.Clear
		dob=Console.ReadLine()
		While chk_dob(dob)=False
			Console.WriteLine("please enter a valid dob")
			dob=Console.ReadLine()
		End While
		filewriter.WriteLine(dob)
		'Console.Clear()
		eml=Console.ReadLine()
		While chk_email(eml)=False
			Console.WriteLine("please enter a valid email address")
			eml=Console.ReadLine()
		End While
		filewriter.WriteLine(eml)
		'Console.Clear()
		End While
		filewriter.Close()
		
		Console.ReadKey(True)
	End Sub
End Module
