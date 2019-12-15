'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/12/11
' Time: 9:40
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim rand As New Random,f_writer As IO.StreamWriter,tmp As String
		f_writer=New IO.StreamWriter("final.txt",True)
		While True
			f_writer.WriteLine(rand.Next(1,6) & " " & rand.Next(1,6) &" " & Date.Today & " " & TimeOfDay)
			tmp=Console.ReadLine()
			If tmp="q" Then
				f_writer.Close()
				Exit Sub
			End If
		End While
		Console.ReadKey(True)
	End Sub
End Module
