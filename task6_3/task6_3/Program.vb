'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/9/1
' Time: 22:04
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'表格的答案：
		'|char.isnumber(string1,3)	|	false
		'|asc('h')					|	104
		'|char.isupper(password,6)	|	true
		'|asc(mid(string1,5,1))		|	122
		'|asc...>64 and asc...<92	|	true
		Dim string1 As String ="Allez Allez!"',password As String="WinInMadrid"
		Console.WriteLine(Char.IsLower(string1,3))
		Console.WriteLine(Asc(Mid(string1,5,1)))
		'Console.WriteLine(Asc("h"))
		'If Asc(Mid(password,4,1))>64 And Asc(Mid(password,4,1))<92 Then
		'	Console.WriteLine("true")
		'Else
		'	Console.WriteLine("false")
		'End If
		Console.ReadKey(True)
	End Sub
End Module
