Module Program
	Sub Main()
		Dim input As Integer,arr(6) As Integer
		input=Console.ReadLine()
		For i As Integer = 0 To 3
			arr(i)=Int(input/10^(3-i))
			input=input-arr(i)*10^(3-i)
			arr(i)+=5
			arr(i)=arr(i) Mod 10
		Next i
		For i As Integer = 3 To 0 Step -1
			Console.Write(arr(i))
		Next 
		Console.ReadKey(True)
	End Sub
End Module
