Module Program
	Public Function abs(x As Integer) As Integer
		If x<0 Then
			Return -x
		End If
		Return x
	End Function
	Sub Main()
		'-----------------------------14.3.1-------------------------------
		Dim n As Integer, arr(100) As String, inp As String
		console.WriteLine("how many elements are in your array? ")
		n=Console.Readline()
		For i As Integer = 1 To n
			Console.WriteLine("please enter element " & i)
			inp=Console.ReadLine()
			arr(i)=inp
		Next i
		Console.WriteLine("here are your array:")
		Console.Write("[ ")
		For j As Integer = 1 To n
			Console.Write(arr(j) & " ")
		Next j
		Console.Write(" ]")
		'-----------------------------14.3.2------------------------------
		'------------------------------one solution-------------------------
		Dim arr2(5) As Integer, inp2 As Integer, rnd As New Random,sum As Integer
		For i As Integer = 1 To 5
			arr2(i)=rnd.Next(-114,514)
			Console.Write(arr2(i) & " ")
			sum=arr2(i)
		Next i
		Console.WriteLine("sum of the array is " & sum)'there are two new solution,segment tree and binary array, the cpp code are in my another repository called oi-template
		'-------------------------------14.3.3-----------------------------------
		Dim odnum As Integer
		For i As Integer = 1 To 5
			If abs(arr2(i)) Mod 2=1 Then'difination of function abs() is outside the main function
				odnum+=1
			End If
		Next i
		console.writeline("there are " & odnum & " odd number and " & 5-odnum & " even number" )
		'-------------------------------14.4.4----------------------------------------
		Dim arr3(5) As Integer
		For i As Integer = 5 To 1 Step -1
			arr3(5-i+1)=arr2(i)
			Console.Write(arr3(i) & " ")'another solution is to use splay to reverse the segment from 1 to 5
		Next i
		Console.ReadKey(True)
	End Sub
End Module
