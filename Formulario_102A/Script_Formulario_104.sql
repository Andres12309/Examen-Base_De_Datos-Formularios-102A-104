create table formulario_104(
	id_Formulario int identity(1,1) PRIMARY KEY,
	Ruc_Usuario varchar(50),

	-----encabezado----
	periodo varchar(50),

	---ventas----
	c401 float,
	c409 float,
	c411 float,
	c419 float,
	c421 float,/*Impuesto generado*/
	c429 float,
	c499 float,

	/*Resumen impositivo*/
	r601 float,
	r605 float,
	r608 float,
	r609 float,
	r615 float,
	r620 float,
	r699 float,
);