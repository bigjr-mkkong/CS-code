Module Program
	Sub Main()
		'--------------------------------13.1.1
		Dim rnd As New Random
		For i=10  To 50 Step 1
			Console.WriteLine(rnd.Next(10,50))
		Next i
		'--------------------------------13.1.2
		Dim upbound As Integer,lowbound As Integer
		upbound=Console.Readline()
		lowbound=Console.ReadLine()
		Dim ans As Integer=rnd.Next(lowbound,upbound),inp As Integer
		inp=Console.ReadLine()
		While inp>ans Or inp<ans
			If inp<ans Then
				Console.WriteLine("your input is too low")
			Else
				Console.WriteLine("your input is too high")
			End If
			inp=Console.ReadLine()
		End While
		Console.WriteLine("correct")
		'----------------------a program to guess the answer--------------
		'--------------------use binary research to guess the number------
		Dim mid As Integer=(upbound-lowbound)/2
		While mid<ans Or mid>ans
			If mid<ans Then
				mid=(mid+upbound)/2
			Else
				mid=(mid+lowbound)/2
			End If
		End While
		Console.WriteLine(mid)
        Console.ReadKey(True)
	End Sub
End Module
