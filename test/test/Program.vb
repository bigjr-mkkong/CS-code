'
' Created by SharpDevelop.
' User: ASUS
' Date: 2019/8/27
' Time: 0:29
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Private Sub bubble_sort(ByRef a As Array)
		Dim t As Integer
		For i = 1 To 9
   			For j = 1 To 10 -i
      			if a(j) < a(j+1) then
        			 t=a(j)
        		 	a(j) = a(j+1)
        		 	a(j+1) = t
      			End if
   			Next j
		Next i		
	End Sub
	Private Sub msort(byref arr As Array,byref temp As Array,l As Integer, r As Integer)
		If l>=r Then
			Exit Sub
		End If
		Dim mid As Integer
		mid=Int((l+r)/2)
		msort(arr,temp,l,mid)
		msort(arr,temp,mid+1,r)
		Dim k As Integer,i As Integer,j As Integer
		k=0
		i=l
		j=mid+1
		While i<=mid And j<=r
			If arr(i)<=arr(j) Then
				temp(k)=arr(i)
				k+=1
				i+=1
			Else
				temp(k)=arr(j)
				k+=1
				j+=1
			End If
		End While
		While i<=mid
			temp(k)=arr(i)
			k+=1
			i+=1
		End While
		While j<=r
			temp(k)=arr(j)
			k+=1
			j+=1
			Console.WriteLine(temp(k))
		End While
		Dim y As Integer
		For p As Integer = l To p<=r step 1
			arr(p)=temp(y)
			y+=1
		Next p
	End Sub
	
	Sub Main()
		Dim arr(1000)As Integer,temp(1000) As Integer
		Dim rand As New Random
		For i As Integer = 1 To 10
			arr(i)=rand.Next(1,11)
		Next i
		msort(arr,temp,1,5)
		For k As Integer=1 To 10
			Console.WriteLine(arr(k))
		Next k
		Console.ReadKey(True)
	End Sub 
End Module
