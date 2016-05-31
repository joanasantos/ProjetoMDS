
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2016 10:33:12
-- Generated from EDMX file: C:\Users\Joana\Desktop\ProjetoMDS\ProjetoMDS\HospitalDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HospitalDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PacienteSet'
CREATE TABLE [dbo].[PacienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MedicoSet'
CREATE TABLE [dbo].[MedicoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConsultaSet'
CREATE TABLE [dbo].[ConsultaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [titulo] nvarchar(max)  NOT NULL,
    [data] datetime  NOT NULL,
    [PacienteId] int  NOT NULL,
    [MedicoId] int  NOT NULL
);
GO

-- Creating table 'MedicamentoSet'
CREATE TABLE [dbo].[MedicamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ConsultaId] int  NOT NULL,
    [observacao] nvarchar(max)  NOT NULL,
    [TipoMedicamentoId] int  NOT NULL
);
GO

-- Creating table 'DiagnosticoSet'
CREATE TABLE [dbo].[DiagnosticoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ConsultaId] int  NOT NULL,
    [observacao] nvarchar(max)  NOT NULL,
    [TipoDiagnosticoId] int  NOT NULL
);
GO

-- Creating table 'SintomaSet'
CREATE TABLE [dbo].[SintomaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ConsultaId] int  NOT NULL,
    [observacao] nvarchar(max)  NOT NULL,
    [TipoSintomaId] int  NOT NULL
);
GO

-- Creating table 'TipoSintomaSet'
CREATE TABLE [dbo].[TipoSintomaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [sintoma] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoMedicamentoSet'
CREATE TABLE [dbo].[TipoMedicamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [medicamento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoDiagnosticoSet'
CREATE TABLE [dbo].[TipoDiagnosticoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [diagnostico] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EnfermeiroSet'
CREATE TABLE [dbo].[EnfermeiroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PacienteSet'
ALTER TABLE [dbo].[PacienteSet]
ADD CONSTRAINT [PK_PacienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicoSet'
ALTER TABLE [dbo].[MedicoSet]
ADD CONSTRAINT [PK_MedicoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [PK_ConsultaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicamentoSet'
ALTER TABLE [dbo].[MedicamentoSet]
ADD CONSTRAINT [PK_MedicamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiagnosticoSet'
ALTER TABLE [dbo].[DiagnosticoSet]
ADD CONSTRAINT [PK_DiagnosticoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SintomaSet'
ALTER TABLE [dbo].[SintomaSet]
ADD CONSTRAINT [PK_SintomaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoSintomaSet'
ALTER TABLE [dbo].[TipoSintomaSet]
ADD CONSTRAINT [PK_TipoSintomaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoMedicamentoSet'
ALTER TABLE [dbo].[TipoMedicamentoSet]
ADD CONSTRAINT [PK_TipoMedicamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoDiagnosticoSet'
ALTER TABLE [dbo].[TipoDiagnosticoSet]
ADD CONSTRAINT [PK_TipoDiagnosticoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EnfermeiroSet'
ALTER TABLE [dbo].[EnfermeiroSet]
ADD CONSTRAINT [PK_EnfermeiroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ConsultaId] in table 'MedicamentoSet'
ALTER TABLE [dbo].[MedicamentoSet]
ADD CONSTRAINT [FK_ConsultaMedicamento]
    FOREIGN KEY ([ConsultaId])
    REFERENCES [dbo].[ConsultaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaMedicamento'
CREATE INDEX [IX_FK_ConsultaMedicamento]
ON [dbo].[MedicamentoSet]
    ([ConsultaId]);
GO

-- Creating foreign key on [ConsultaId] in table 'SintomaSet'
ALTER TABLE [dbo].[SintomaSet]
ADD CONSTRAINT [FK_ConsultaSintoma]
    FOREIGN KEY ([ConsultaId])
    REFERENCES [dbo].[ConsultaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaSintoma'
CREATE INDEX [IX_FK_ConsultaSintoma]
ON [dbo].[SintomaSet]
    ([ConsultaId]);
GO

-- Creating foreign key on [ConsultaId] in table 'DiagnosticoSet'
ALTER TABLE [dbo].[DiagnosticoSet]
ADD CONSTRAINT [FK_ConsultaDiagnostico]
    FOREIGN KEY ([ConsultaId])
    REFERENCES [dbo].[ConsultaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaDiagnostico'
CREATE INDEX [IX_FK_ConsultaDiagnostico]
ON [dbo].[DiagnosticoSet]
    ([ConsultaId]);
GO

-- Creating foreign key on [PacienteId] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([PacienteId])
    REFERENCES [dbo].[PacienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[ConsultaSet]
    ([PacienteId]);
GO

-- Creating foreign key on [MedicoId] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([MedicoId])
    REFERENCES [dbo].[MedicoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[ConsultaSet]
    ([MedicoId]);
GO

-- Creating foreign key on [TipoSintomaId] in table 'SintomaSet'
ALTER TABLE [dbo].[SintomaSet]
ADD CONSTRAINT [FK_TipoSintomaSintoma]
    FOREIGN KEY ([TipoSintomaId])
    REFERENCES [dbo].[TipoSintomaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoSintomaSintoma'
CREATE INDEX [IX_FK_TipoSintomaSintoma]
ON [dbo].[SintomaSet]
    ([TipoSintomaId]);
GO

-- Creating foreign key on [TipoDiagnosticoId] in table 'DiagnosticoSet'
ALTER TABLE [dbo].[DiagnosticoSet]
ADD CONSTRAINT [FK_TipoDiagnosticoDiagnostico]
    FOREIGN KEY ([TipoDiagnosticoId])
    REFERENCES [dbo].[TipoDiagnosticoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDiagnosticoDiagnostico'
CREATE INDEX [IX_FK_TipoDiagnosticoDiagnostico]
ON [dbo].[DiagnosticoSet]
    ([TipoDiagnosticoId]);
GO

-- Creating foreign key on [TipoMedicamentoId] in table 'MedicamentoSet'
ALTER TABLE [dbo].[MedicamentoSet]
ADD CONSTRAINT [FK_TipoMedicamentoMedicamento]
    FOREIGN KEY ([TipoMedicamentoId])
    REFERENCES [dbo].[TipoMedicamentoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoMedicamentoMedicamento'
CREATE INDEX [IX_FK_TipoMedicamentoMedicamento]
ON [dbo].[MedicamentoSet]
    ([TipoMedicamentoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------