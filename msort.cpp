#include<bits/stdc++.h>
using namespace std;
const int maxn = 1e5 + 5;
int q[maxn] , temp[maxn];
void merge_sort(int q[] , int l , int r)
{
    if(l >= r) return;
    int mid = l + r >> 1;
    merge_sort(q , l , mid);
    merge_sort(q , mid + 1 , r);
    int k = 0 , i = l , j = mid + 1;
    while(i <= mid && j <= r)
        if(q[i] <= q[j]) temp[k++] = q[i++];
        else temp[k++] = q[j++];
    while(i <= mid) temp[k++] = q[i++];
    while(j <= r) temp[k++] = q[j++];
    for(int i = l , j = 0; i <= r; i++ , j++) q[i] = temp[j];
}

int main()
{
    int n;
    scanf("%d" , &n);
    for(int i = 0;i < n;i++) scanf("%d" , &q[i]);
    merge_sort(q , 0 , n-1);
    for(int i = 0;i < n;i++) printf("%d " , q[i]);
    return 0;
}
