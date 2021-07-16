#include <stdio.h>
#define vao "Dijkstra.inp"
#define ra "Dijkstra.out"
#define max 1000
#define maxC -1

long n, m, s, f;
long kq;
long c[max][max];

void nhap()
{
	FILE *f1;
    f1 = fopen(vao, "r");
    fscanf(f1, "%d%d", &n, &m);
    
    //Khoi tao ma tran ke
    for (long u = 1; u <= n; u++)
    	for (long v = 1; v <= n; v++)
 		{   	
    		if (u == v)
    			c[u][v] = 0;
    		else
    			c[u][v] = maxC;
    	}
    	
    //Doc danh sach canh --> ma tran ke tuong ung
    for (long i = 1; i <= m; i++)
    {
    	long u, v, x;
    	fscanf(f1, "%d%d%d", &u, &v, &x);
    	c[v][u] = c[u][v] = x;
	}
	
    fclose(f1);	
}


void xuat()
{
	FILE *f2;
	f2=fopen(ra,"w");
    for (int i=1;i<=n;i++)
    {
        for (int j=1;j<=n;j++)
        {
        	fprintf (f2,"%d\t ",c[i][j]);
        	
        }
         fprintf (f2,"\n"); 
     	
    }
    fclose(f2);	
}

int main()
{
    nhap();
	xuat();
    return 0;
}
