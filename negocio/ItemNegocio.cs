﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ItemNegocio
    {
        public List<Items> listar()
        {
            List<Items> itemList = new List<Items>();

            DataAccess data = new  DataAccess();
            data.settingQuery("select a.Id id, Codigo, Nombre, a.Descripcion description, ImagenUrl, Precio, m.Descripcion Marca, c.Descripcion Categoria, m.Id marcaid, c.Id categoriaid from ARTICULOS a, MARCAS m, CATEGORIAS c where IdMarca=m.Id and IdCategoria=c.Id");
            data.executeQuery();

            while(data.Reader.Read())
            {
                Items aux = new Items();

                aux.Id = (int)data.Reader["Id"];
                aux.ItemCode = (string)data.Reader["Codigo"];
                aux.Name = (string)data.Reader["Nombre"];
                aux.Description = (string)data.Reader["description"];
                aux.UrlImage = (string)data.Reader["ImagenUrl"];
                aux.Price = (decimal)data.Reader["Precio"];
                aux.CategoryDescription = new Category();
                aux.CategoryDescription.CategoryId = (int)data.Reader["categoriaid"];
                aux.CategoryDescription.CategoryDescription = (string)data.Reader["Categoria"];
                aux.TradeDesciption = new Trademarks();
                aux.TradeDesciption.TradeId = (int)data.Reader["marcaid"];
                aux.TradeDesciption.TradeDescription = (string)data.Reader["Marca"];

                itemList.Add(aux);
            }
            data.closeConnection();

            return itemList;
        }
        public void add(Items item)
        {
            DataAccess data = new DataAccess();
            try

            {
                data.settingQuery("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@code,@name,@desc,@idm,@idc,@url,@price)");
                data.settingParametter("@code",item.ItemCode);
                data.settingParametter("@name",item.Name);
                data.settingParametter("@desc",item.Description);
                data.settingParametter("@idm",item.TradeDesciption.TradeId);
                data.settingParametter("@idc",item.CategoryDescription.CategoryId);
                data.settingParametter("@url",item.UrlImage);
                data.settingParametter("@price",item.Price);
                data.executeAction();




            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.closeConnection();
            }
            
        }
        public void modify(Items item)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.settingQuery("update articulos set codigo = @code,Nombre =@name,descripcion=@desc,idmarca =@idtrade,idcategoria=@idcategory,imagenurl=@url,precio=@price where Id=@id");
                data.settingParametter("@code",item.ItemCode);
                data.settingParametter("@name",item.Name);
                data.settingParametter("@desc",item.Description);
                data.settingParametter("@idtrade",item.TradeDesciption.TradeId);
                data.settingParametter("@idcategory",item.CategoryDescription.CategoryId);
                data.settingParametter("@url",item.UrlImage);
                data.settingParametter("@price",item.Price);
                data.settingParametter("@id", item.Id);
                data.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.closeConnection();
            }
        }
        public void delete(Items item)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.settingQuery("delete from articulos where id=@id");
                data.settingParametter("@id",item.Id);
                data.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.closeConnection();
            }
        }
        public List<Items> filtrate(string field, string standar, string filter)
        {
            List<Items> listItem = new List<Items>();
            DataAccess data = new DataAccess();
            try
            {
                string querry = "select a.id, Codigo, Nombre, a.Descripcion description, ImagenUrl, Precio, m.Descripcion Marca, c.Descripcion Categoria, m.Id marcaid, c.Id categoriaid from ARTICULOS a, MARCAS m, CATEGORIAS c where IdMarca=m.Id and IdCategoria=c.Id and ";
                if (field == "Item Code")
                {
                    switch (standar)
                    {
                        case "Start with:":
                            querry += "Codigo like '" + filter + "%'";
                            break;
                        case "Ends with:":
                            querry += "Codigo like '%" + filter + "'";
                            break;
                        case "contains:":
                            querry += "Codigo like '%" + filter + "%'";
                            break;
                    }
                }
                else if (field == "Item")
                {
                    switch (standar)
                    {
                        case "Start with:":
                            querry += "nombre like '" + filter + "%'";
                            break;
                        case "Ends with:":
                            querry += "nombre like '%" + filter + "'";
                            break;
                        case "contains:":
                            querry += "nombre like '%" + filter + "%'";
                            break;
                    }
                }
                else
                {
                    switch (standar)
                    {
                        case "Greater than:":
                            querry += "precio >" + filter;
                            break;
                        case "Lower than:":
                            querry += "precio <" + filter;
                            break;
                        case "Equal to:":
                            querry += "precio =" + filter;
                            break;
                    }
                }
                data.settingQuery(querry);
                data.executeQuery();

                while (data.Reader.Read())
                {
                    Items aux = new Items();

                    aux.Id = (int)data.Reader["Id"];
                    aux.ItemCode = (string)data.Reader["Codigo"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["description"];
                    aux.UrlImage = (string)data.Reader["ImagenUrl"];
                    aux.Price = (decimal)data.Reader["Precio"];
                    aux.CategoryDescription = new Category();
                    aux.CategoryDescription.CategoryId = (int)data.Reader["categoriaid"];
                    aux.CategoryDescription.CategoryDescription = (string)data.Reader["Categoria"];
                    aux.TradeDesciption = new Trademarks();
                    aux.TradeDesciption.TradeId = (int)data.Reader["marcaid"];
                    aux.TradeDesciption.TradeDescription = (string)data.Reader["Marca"];

                    listItem.Add(aux);
                    

                }
                return listItem;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.closeConnection();
            }


            
        }
    }
}
