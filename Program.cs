using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace MoveOfGoods
{

  public class Program
  {

    ///
    ///
    ///
    ///
    public static void Main(string[] args)
    {


      // Lets ensure data integrity and maintanace
      //
      /// http://info.portaldasfinancas.gov.pt/pt/apoio_contribuinte/Documents/documentosTransporte.wsdl
      /// http://info.portaldasfinancas.gov.pt/pt/apoio_contribuinte/Documents/GuiasAquisicaoProdAgricola.wsdl

      /// 7xx is test environment 4xx is production
      /// Shipping documents
      /// https://servicos.portaldasfinancas.gov.pt:701/sgdtws/documentosTransporte

      /// Purchases of agriculture products
      /// https://servicos.portaldasfinancas.gov.pt:702/sgdtws/GuiasAquisicaoProdAgricola

      /// Submit audit data 
      /// https://info.portaldasfinancas.gov.pt/apps/saft-pt01/SAFTPT1.01_01.xsd
      /// https://info.portaldasfinancas.gov.pt/apps/saft-pt02/SAFTPT1.02_01.xsd
      /// https://info.portaldasfinancas.gov.pt/apps/saft-pt03/SAFTPT1.03_01.xsd
      /// https://info.portaldasfinancas.gov.pt/apps/saft-pt04/saftpt1.04_01.xsd
	  
      // We got the C# code working, wow what a hazzle...
      // AT Issuing CA1.p7b
      X509Certificate2 _X509Cer = new X509Certificate2(lPathCertificate, "", X509KeyStorageFlags.Exportable); //DefaultKeySet
      Console.WriteLine(string.Format("_X509Cer:[{3}], Cert Subject: [{0}], NotBefore: [{1}], NotAfter: [{2}]", _X509Cer.Subject, _X509Cer.NotBefore, _X509Cer.NotAfter, _X509Cer.GetRSAPublicKey().ToXmlString(false)));
      X509Certificate2 _X509Key = new X509Certificate2(lPathPublicKey, "TESTEwebservice", X509KeyStorageFlags.DefaultKeySet);
      Console.WriteLine(string.Format("_X509Key:[{3}], Cert Subject: [{0}], NotBefore: [{1}], NotAfter: [{2}]", _X509Key.Subject, _X509Key.NotBefore, _X509Key.NotAfter, _X509Key.GetRSAPublicKey().ToXmlString(false)));


    }

  }
}
