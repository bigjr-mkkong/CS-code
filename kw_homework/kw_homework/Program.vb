Module Program
	Sub Main()
		Dim score As Integer
		score=Console.ReadLine()
		Select Case score
			Case <=40
				Console.Write("F" & vbCrLf & "Failed")
		    Case <=50 
		    	Console.Write("E" & vbCrLf & "Failed")
		    Case <=60
		    	Console.Write("D" & vbCrLf & "Miss")
		    Case <=70
		    	Console.Write("C" & vbCrLf & "Bad")
		    Case <=80
		    	Console.Write("B" & vbCrLf & "Good")
		    Case <=90
		    	Console.Write("A" & vbCrLf & "Great")
		    Case <=100
		    	Console.Write("A*" & vbCrLf & "Perfect")
		    Case Else
		    	Console.WriteLine("Score should in [0,100]")
		End Select
		Console.ReadKey(True)
	End Sub
End Module
