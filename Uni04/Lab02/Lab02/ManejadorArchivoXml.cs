using System.Data;

namespace Lab02
{
    public class ManejadorArchivoXml : ManejadorArchivo
    {
        protected DataSet ds;

        public override DataTable GetTabla()
        {
            this.ds = new DataSet();
            this.ds.ReadXml("agenda.xml");
            return this.ds.Tables["contactos"];
        }

        public override void AplicaCambios()
        {
            this.ds.WriteXml("agenda.xml");
            this.ds.WriteXml("agendaconschema.xml", XmlWriteMode.WriteSchema);
        }
    }
}
