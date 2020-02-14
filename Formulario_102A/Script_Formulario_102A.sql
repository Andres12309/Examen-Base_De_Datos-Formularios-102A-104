create table Usuarios(
	id_Usuario int identity(1,1) PRIMARY KEY,
	Ruc_Usuario varchar(20),
)
create table formulario_102A(
	id_Formulario int identity(1,1) PRIMARY KEY,
	id_Usuario int,

	-----encabezado----
	periodo varchar(50),
	NoEmpleados int,

	/*Ingresos*/
	i481 int,
	i718 int,
	i729 int, /*subtotal*/
	i741 int,

	/*Gastos deducibles*/
	g491 int,
	g739 int, /*subtotal*/
	g751 int,

	/*Renta imponible*/
	r749 int,	
	r759 int,
	r769 int,

	/*Otras deducciones y exoneraciones*/
	b740 varchar(25),

	/*Aplicable al período*/
	p768 int,
	p771 int,
	p772 int,
	p773 int,
	p774 int,
	p775 int,
	p779 int,
	p780 int, /*Total gastos personales*/


	/*Resumen impositivo*/
	c832 int,
	c839 float,
	c840 int,
	c845 int,
	c846 int,
	c855 float,/*subtotal impuesto a pagar*/
	c856 float,/*subtotal a favor*/
	c859 float,
	c869 float,
	FOREIGN KEY (id_Usuario) REFERENCES Usuarios(id_Usuario)
);