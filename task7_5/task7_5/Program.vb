'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/9/1
' Time: 22:29
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'-----------------------7.5.1-------------------------
		Dim flag As Boolean=False,num1 As Integer,num2 As Integer
		num1=Int(Console.ReadLine())
		num2=Int(Console.ReadLine())
		If num1=num2 Then
			flag=True
		End If
		Console.WriteLine(flag)
		'---------------------7.5.2----------------------------
		Dim string1 As String,string2 As String
		string1=Console.ReadLine()
		string2=Console.ReadLine()
		If Char.IsLetter(string1,3) Then
			string2=string2 & Mid(string1,3,1)
			Console.WriteLine(string2)
		ElseIf Char.IsNumber(string1,3) Then
			Console.WriteLine("this character is a number")
		Else
			Console.WriteLine("this is a special character")
		End If
		'--------------------------7.5.3----------------------------
		If string1="Anfield" Or string2="Anfield" Then
			If flag=True Then
				Console.WriteLine("Allez Allez Allez")
			Else
				Console.WriteLine("better luck next time")
			End If
		End If
		'--------------------------7.5.4-----------------------------
		If num1>=1 And num1<=50 Then
			flag=True
			string1=string1 & Str(num1) & " "
			Console.WriteLine(string1)
		ElseIf num1>=51 And num1<=100 Then
			string2=string2 & Str(num1) & " "
			Console.WriteLine(string2)
		End If
		Console.ReadKey(True)
	End Sub
End Module
