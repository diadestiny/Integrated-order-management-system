create table  �ͻ�(
�ͻ��˺�  varchar(30) primary key,
�ͻ����� varchar(30),
��¼����   varchar(30) not null,
�Ա� varchar(5) default '��',
��ס�� varchar(30),
�ֻ����� bigint 
)

create table  �̼�(
�̼��˺�  varchar(30) primary key ,
��¼����  varchar(30) not null,
�������� varchar(30),
���̵�ַ varchar(30),
��ϵ�绰 bigint 
)

create table  ��Ʒ(
��Ʒ���  bigint primary key identity(1,1),
��Ʒ���� varchar(30),
�ϼ�ʱ�� date,
�۸� int,
��Ʒ��� varchar(100),
�����̼� varchar(30) foreign key references  �̼�(�̼��˺�)
)

create table  ����(
�������  bigint primary key identity(1,1),
�ʹ��ַ  varchar(30),
�µ�ʱ�� datetime,
�ͻ��˺� varchar(30) foreign key references  �ͻ�(�ͻ��˺�),
��Ʒ��� bigint foreign key references  ��Ʒ(��Ʒ���)
)

