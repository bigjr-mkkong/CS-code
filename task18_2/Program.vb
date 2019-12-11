'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/12/11
' Time: 9:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim f_reader As IO.StreamReader,f_writer As IO.StreamWriter,rand As New Random
		Dim name As String,suf(10) As String
		f_reader=New IO.StreamReader("name.txt")
		name=f_reader.ReadLine()
		f_reader.Close()
		f_reader=New IO.StreamReader("suffix.txt")
		For i As Integer = 1 To 5
			suf(i)=f_reader.ReadLine()
		Next i
		f_reader.Close()
		f_writer=New IO.StreamWriter("output.txt",True)
		f_writer.WriteLine(name & " " & suf(rand.Next(1,5)))
		Console.ReadKey(True)
	End Sub
End Module
