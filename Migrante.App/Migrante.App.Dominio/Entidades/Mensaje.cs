using System;

namespace Migrante.App.Dominio;

public class Mensaje{
public int id {get;set;}
public int timestamp {get;set;}
public int id_remitente {get;set;}
public int id_destinatario {get;set;}
public int asuntocuerpo {get;set;}
public boolean leido = false {get;set;}

}