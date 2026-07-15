Algoritmo Lecc17_Act3_Inc2
	Definir f,c,x,yy,m Como Entero
	Definir t Como Entero
	Dimension t[4,4]
	
	Para f=1 Hasta 4 Hacer
		Para c=1 Hasta 3 Hacer
			Escribir "Ingrese un numero"
			Leer t[f,c]
		FinPara
	Fin Para
	m=t[1,1]
	x=1
	yy=1
	
	Para f=1 Hasta 4  Hacer
		Para c=1 Hasta 4  Hacer
			Si t[f,c]>m Entonces
				m=t[f,c]
				x=f
				yy=c
			FinSi
		FinPara
	Fin Para
	
	Escribir "El numero mayor es: ',m
	Escribir "Esta en la fila ",x
	Escribir "Y en la columna ",yy
	
FinAlgoritmo
