CREATE TABLE [dbo].[Especialidade](
	[Id] INT NOT NULL PRIMARY KEY,
	[Nome] varchar not null
);

CREATE TABLE [dbo].[Cidade](
	[Id] INT NOT NULL PRIMARY KEY,
	[Nome] varchar not null
);

CREATE TABLE [dbo].[Medico]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Nome] varchar not null,
	[Cidade_fk] int foreign key references Cidade (id) not null,
	[Especialidade_fk] int foreign key references Especialidade (id) not null
)
