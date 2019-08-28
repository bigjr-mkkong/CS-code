'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/8/28
' Time: 21:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
'bubble sort
Module Program
	Sub Main()
		Dim arr(100) As Integer
		Dim n As Integer
		n=Int(Console.ReadLine())
		For i As Integer =1 To n
			arr(i)=Int(Console.ReadLine())
		Next i
		Dim temp As Integer
		For i = 1 To n - 1
			For j = 1 To n-i
				If arr(j) > arr(j+1) Then
					temp=arr(j)： arr(j)=arr(j+1)： arr(j+1)=temp
				End if
			Next j
		Next i
		For i As Integer=1 To n
			Console.Write(Str(arr(i)))
		Next i
		Console.ReadKey(True)
	End Sub
End Module
