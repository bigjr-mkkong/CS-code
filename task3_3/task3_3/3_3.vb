'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/8/31
' Time: 18:28
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'---------------------------------3.3.1------------------------------------------------
		Dim StudentName As String, StudentAge As Integer, StudentGender As Char
		Console.Write("Please enter your name:  ")
		StudentName=Console.ReadLine()
		Console.Write("Please enter your age:  ")
		StudentAge=Console.ReadLine()
		Console.Write("Please enter your gender(M/W):  ")
		StudentGender=Console.ReadLine()
		'Console.WriteLine("name: {0}"+vbCrLf+"age:  {1}"+vbCrLf+"gender:  {2}",StudentName,StudentAge,StudentGender)
		'----------------------------------3.3.2--------------------------------------------------
		Console.WriteLine("Hello {0}, I hope you're having a great day",StudentName)
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
