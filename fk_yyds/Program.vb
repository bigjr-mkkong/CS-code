Module Program
Public RegTable(5,1926) As String			
	Sub Menu()
		Console.WriteLine("Pelase choose your operation")
		Console.WriteLine("1. Add new score")
		Console.WriteLine("2. Display all score")
		Console.WriteLine("3. Search by Membership Number")
		Console.WriteLine("4. Search by score")
		Console.WriteLine("5. Add new Score")
	End Sub
	Function InitFile() As Integer
		Dim FileReader As IO.StreamReader
		Dim NumOfReg As Integer
		Dim tmp As String()
		FileReader=New IO.StreamReader("MEMREG.txt",True)
		While Not FileReader.EndOfStream
			NumOfReg=NumOfReg+1
			tmp=FileReader.ReadLine().Split(" ")
			For i As Integer = 1 To 3
				RegTable(i,NumOfReg)=tmp(i-1)
			Next i
		End While
		FileReader.Close()
		Return NumOfReg
	End Function
	
	Function SyncWihFile(ByVal NumOfReg As Integer) As Boolean
		Dim FileWriter As IO.StreamWriter
		FileWriter=New IO.StreamWriter("MEMREG.txt")
		For OuterIndex As Integer = 1 To NumOfReg
			For InnerIndex As Integer = 1 To 3
				FileWriter.Write(RegTable(InnerIndex,OuterIndex) & " ")
			Next InnerIndex
			FileWriter.WriteLine()
		Next OuterIndex
		FileWriter.Close()
		Return True
	End Function
	
	Function AddRecord(ByRef NumOfReg As Integer, ByVal rec As String) As Boolean
		NumOfReg=NumOfReg+1
		Dim tmp As String()
		tmp=rec.Split(" ")
		For Index As Integer = 1 To 3
			RegTable(Index,NumOfReg)=tmp(Index-1)
		Next Index
		Return True
	End Function
	
	Function SelectRecord(ByVal NumOfReg As Integer, ByVal Field As Integer, ByVal FieldReq As String) As Integer
		Dim SelectNum As Integer
		If Field>0 And Field<4 Then
			'display certain records match certian field
			For Index As Integer = 1 To NumOfReg
				If RegTable(Field,Index) =FieldReq Then
					Console.Write(RegTable(1,Index) & " ")
					Console.Write(RegTable(2,Index) & " ")
					Console.Write(RegTable(3,Index))
					Console.WriteLine()
					SelectNum=SelectNum+1
				End If
			Next Index
		Else
			'display all of the rec
			For Index As Integer = 1 To NumOfReg
				Console.Write(RegTable(1,Index) & " ")
				Console.Write(RegTable(2,Index) & " ")
				Console.Write(RegTable(3,Index))
				Console.WriteLine()
				SelectNum=SelectNum+1
			Next Index
		End If
		Console.WriteLine()
		Return SelectNum
	End Function
	
	Function AddNewScores(Byref NumOfReg As Integer) As Boolean
		Dim MemName As String
		Dim Score As Integer
		Dim DateOfSc As String
		Console.WriteLine("Please enter the date of score")
		DateOfSc=Console.ReadLine()
		Console.WriteLine("Please enter the membership of this score")
		MemName=Console.ReadLine()
		If MemName="" Then
			Return False
		End If
		Do
			Console.WriteLine("Please enter the score")
			Score=Int(Console.ReadLine())
		Loop While Score<50 Or Score>99
		'Console.WriteLine(MemName & " " & DateOfSc & Str(Score))
		AddRecord(NumOfReg, MemName & " " & DateOfSc & Str(Score))
		Return True
	End Function
	
	Sub Main()
		Dim UserOperation As String
		Dim NumOfReg As Integer
		Dim UserMemNum As String
		Dim UserScore As String
		NumOfReg=0
		Dim UserRecAdd As String
		Menu()
		NumOfReg=InitFile()
		While True
			UserOperation=Console.ReadLine()
		Select Case UserOperation
			Case "1"
				Console.WriteLine("Please enter the new record")
				UserRecAdd=Console.ReadLine()
				AddRecord(NumOfReg,UserRecAdd)
			Case "2"
				SelectRecord(NumOfReg,-1,"qwq")
			Case "3"
				Console.WriteLine("Please input the membership number")
				UserMemNum=Console.ReadLine()
				SelectRecord(NumOfReg,1,UserMemNum)
			Case "4"
				Console.WriteLine("Please input the score")
				UserScore=Console.ReadLine()
				SelectRecord(NumOfReg,3,UserScore)
			Case "5"
				AddNewScores(NumOfReg)
			Case "q"
				SyncWihFile(NumOfReg)
				Console.WriteLine("program will exit")
				Console.ReadKey(True)
				Exit Sub
		    Case Else
				Console.WriteLine("we do not have this choice")
		End Select
		SyncWihFile(NumOfReg)
		End While
	End Sub
End Module
