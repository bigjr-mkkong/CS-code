Module Program
	Sub Main()
		Dim hour As Double,rate As Double
		Console.WriteLine("please enter the hour(s) work: ")
		hour=Console.ReadLine()
		Console.WriteLine("please enter the work pay rate :")
		rate=Console.ReadLine()
		Console.WriteLine("total work pay is: " & hour*rate)
		Console.ReadKey(True)
	End Sub
End Module
