insert into [Especialidade] ([nome]) values ('cirurgia');

insert into [Cidade] ([nome]) values ('Londrina');

insert into [Medico] ([Nome], [Email], [EspecialidadeId], [CidadeId]) 
values ('Daniel Junior', 'dj@medico.com', 1, 1);

insert into [Medico] ([Nome], [Email], [EspecialidadeId], [CidadeId]) 
values ('Douglas Souza', 'ds@medico.com', 1, 1);

insert into [Cidade] ([Nome]) values ('Ibiporã');

insert into Especialidade ([Nome]) values ('Pediatra');

insert into [Medico] ([Nome], [Email], [CidadeId], [EspecialidadeId]) values 
('Rodrigo Maia', 'rm@medico.com', 2, 2); 

insert into [Usuario] ([Nome], [Username], [Password], [Role]) values ('Daniel Junior', 'adm', '123', 'Adm');

insert into [Usuario] ([Nome], [Username], [Password]) values ('Pratinha Master', 'user', '456');
