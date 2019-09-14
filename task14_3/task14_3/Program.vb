Module Program
	Sub Main()
		Dim n As Integer, arr(100) As Integer, inp As Integer
		console.WriteLine("how many elements are in your program? ")
		n=Console.Readline()
		For i As Integer = 1 To n
			Console.WriteLine("please enter element " & i)
			inp=Console.ReadLine()
			arr(i)=inp
		Next i
				
		Console.ReadKey(True)
	End Sub
End Module
