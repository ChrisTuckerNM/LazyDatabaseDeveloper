/*
    Released to use as you see fit, no warrenties though.

    Thanks to Ed Elliot for the plain english help needed to translate the dac
    model.

    https://sqlserverfunctions.wordpress.com/2014/09/27/querying-the-dacfx-api-getting-column-type-information/

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;


namespace DacTools
{
    public static class Tools
    {
        public static List<TSqlObject> Tables(this TSqlModel model)
        {
            List<TSqlObject> allTables = new List<TSqlObject>();

            // This model represents the last successfully compiled dacpac, not the model in memory.  To
            // get the latest information about your schema make sure to compile your project prior to
            // executing the text template.  The model is of type Microsoft.SqlServer.Dac.Model.TSqlModel.
            if (model != null)
            {
                var tables = model.GetObjects(DacQueryScopes.All, ModelSchema.Table);
                if (tables != null)
                {
                    allTables.AddRange(tables);
                }
            }
            return allTables;
        }

        /// <summary>
        ///     Return all columns for the current tsql object.
        /// Returns null if the incorrect object type is passed int
        /// </summary>
        /// <param name="table"></param>
        /// <returns>List<TSqlObject></returns>
        public static List<TSqlObject> Columns(this TSqlObject table)
        {
            //Retreive the relationships of type columns, the relationships 
            //object is the column
            return table.GetReferencedRelationshipInstances(Table.Columns)
                .Select(c => c.Object)
                .ToList();
        }

        public static List<TSqlObject> PrimaryKeyColumns(this TSqlObject table)
        {
            //Retreive the relationships of type Primary Key Columns, the relationships 
            //object is the column, SEE A PATTERN HERE?
            var temp = table.GetReferencing()
                .Where(o => o.ObjectType.Name == "PrimaryKeyConstraint")
                .First() //only one primary Key Constraint
                .GetReferenced()
                .Where(t => t.ObjectType.Name == "Column");
            
            return temp.ToList();
        }


             
       
    }
    public enum ColumnPartName
    {
        Schema = 0
        ,Table = 1
        ,Column = 2
    }
}
