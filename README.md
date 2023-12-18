## DB Init Script

```
CREATE SCHEMA [nattachment] AUTHORIZATION [dbo];

GO

create table nattachment.attachment
(
id   int identity
constraint PK_attachment
primary key,
data varbinary(max),
)

```