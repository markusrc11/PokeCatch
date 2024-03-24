using System;
using System.IO;
using System.Xml.Serialization;

namespace PokeCatch
{
    public class Puntuacio
    {
        #region Atributs privats
        int punts;
        string dificultat;
        #endregion

        #region Propietats

        public int Punts
        {
            get { return punts; }

            set { punts = value; }
        }

        public string Dificultat
        {
            get { return dificultat; }
            set { dificultat = value; }
        }

        #endregion

        #region Metodes

        /// <summary>
        /// Guarda l'estat de l'objecte en un fitxer XML
        /// </summary>
        public void Serialitzar()
        {
            
            // Agafa les propietats de la classe Persona
            XmlSerializer serializer = new XmlSerializer(typeof(Puntuacio));
            // Crea un fitxer amb estructura xml
            StreamWriter writer = new StreamWriter("puntuacio" + dificultat + ".xml");
            serializer.Serialize(writer, this);
            writer.Close();
        }

        /// <summary>
        /// Recupera l'estat d'un objecte desde un fitxer XML
        /// </summary>
        public void Deserialitzar()
        {
           // Agafa les propietats de la classe Persona
            XmlSerializer serializer = new XmlSerializer(typeof(Puntuacio));
            try
            {
                using (FileStream fs = new FileStream("puntuacio" + dificultat + ".xml", FileMode.Open))
                {
                    // Declaro un objecte de tipus persona on deserialitzo
                    Puntuacio p;
                    // El mètode Deserialize em carrega els valors del xml a l'objecte p
                    // with data from the XML document. */
                    p = (Puntuacio)serializer.Deserialize(fs);
                    // Assigno les propietats a la propia instancia this
                    this.Punts = p.Punts;
                }
            }
            //En cas que es produeixi algun error (no troba el fitxer...) inicialitzem per defecte
            catch (Exception)
            {
                this.Punts = 0;
               
            }
        }
    }

        #endregion
    }

