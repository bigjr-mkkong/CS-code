'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/9/15
' Time: 22:58
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim arr(10) As Integer,rnd As New Random,inp As Integer,ind As Integer,p As Integer=1
		Dim cnt(1926) As Integer,che As Integer
		While p<=10
			che=rnd.Next(1,1926)
			If cnt(che)=1 Then
				p-=1
			Else
				arr(p)=che
				cnt(p)=1
			End If
			p+=1
		End While
		Console.WriteLine("which number you want to search?")
		inp=Console.ReadLine()
		For ind  = 1 To 10
			If arr(ind) = inp Then
				GoTo suc
			End If
		Next ind
		Console.WriteLine("your number is not inside the array")
		Console.ReadKey(True)
		Exit Sub
		suc:
		Console.WriteLine("your number is in the array ans the index is " & ind)
		Console.ReadKey(True)
	End Sub
End Module
