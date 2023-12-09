using System;
using System.Collections.Generic;

namespace DecodeNencode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce:\ntrue para Encode\nfalse para Decode");//input que determina que opcion quieres elegir
            bool firstCond = Convert.ToBoolean(Console.ReadLine());

            Dictionary<string, string> encodeDictionary = new Dictionary<string, string>()
            {
                {"Acapulco", "ACA"},
                {"Aguascalientes", "AGU"},
                {"Alamos", "XAL"},
                {"Apatzingan", "AZG"},
                {"Atizapan", "JJC"},
                {"Cabo San Lucas", "CSL"},
                {"Campeche", "CPE"},
                {"Cananea", "CNA"},
                {"Cancún", "CUN"},
                {"Celaya", "CYW"},
                {"Chetumal", "CTM"},
                {"Chichén Itzá", "CZA"},
                {"Chihuahua", "CUU"},
                {"Ciudad Acuña", "ACN"},
                {"Ciudad Constitucion", "CUA"},
                {"Ciudad de México", "MEX"},
                {"Ciudad del Carmen", "CME"},
                {"Ciudad Juárez", "CJS"},
                {"Ciudad Mante", "MMC"},
                {"Ciudad Obregón", "CEN"},
                {"Ciudad Pemex", "CPX"},
                {"Ciudad Victoria", "CVM"},
                {"Colima", "CLQ"},
                {"Comitán", "CJT"},
                {"Cozumel", "CZM"},
                {"Cuernavaca", "CVJ"},
                {"Culiacán", "CUL"},
                {"Durango", "DGO"},
                {"Ensenada", "ESE"},
                {"Frontera", "LOV"},
                {"Guadalajara", "GDL"},
                {"Guaymas", "GYM"},
                {"Guerrero Negro", "GUB"},
                {"Hermosillo", "HMO"},
                {"Huatulco", "HUX"},
                {"Isla Cedros", "CDI"},
                {"Isla Mujeres", "ISJ"},
                {"Ixtapa", "ZIH"},
                {"Ixtepec", "IZT"},
                {"La Paz", "LAP"},
                {"Lagos de Moreno", "LOM"},
                {"Lázaro Cárdenas", "LZC"},
                {"León", "BJX"},
                {"Loreto", "LTO"},
                {"Los Cabos", "SJD"},
                {"Los Mochis", "LMM"},
                {"Manzanillo", "ZLO"},
                {"Matamoros", "MAM"},
                {"Mazatlán", "MZT"},
                {"Mérida", "MID"},
                {"Mexicali", "MXL"},
                {"Minatitlán", "MTT"},
                {"Monterrey", "MTY"},
                {"Morelia", "MLM"},
                {"Mulegé", "MUG"},
                {"Navojoa", "NAV"},
                {"Nogales", "NOG"},
                {"Nuevo Casas Grandes", "NCG"},
                {"Nuevo Laredo", "NLD"},
                {"Oaxaca", "OAX"},
                {"Pachuca", "PCA"},
                {"Palenque", "PQM"},
                {"Piedras Negras", "PDS"},
                {"Pijijiapan", "PJP"},
                {"Poza Rica", "PAZ"},
                {"Puerto Escondido", "PXM"},
                {"Puerto Peñasco", "PPE"},
                {"Puerto Vallarta", "PVR"},
                {"Querétaro", "QRO"},
                {"Reynosa", "REX"},
                {"Salina Cruz", "SCX"},
                {"Saltillo", "SLW"},
                {"San Cristobal de las Casas", "SZT"},
                {"San Felipe", "SFH"},
                {"San Luis Potosí", "SLP"},
                {"San Luis Río Colorado", "UAC"},
                {"Santa Rosalía", "PVP"},
                {"Tampico", "TAM"},
                {"Tamuín", "TCN"},
                {"Tapachula", "TAP"},
                {"Teacapán", "TCP"},
                {"Tehuacán", "TCN"},
                {"Tepic", "TNY"},
                {"Tijuana", "TIJ"},
                {"Tizimín", "TZM"},
                {"Toluca", "TLC"},
                {"Torreón", "TRC"},
                {"Tulum", "TUY"},
                {"Tuxpan", "TUX"},
                {"Tuxtla Gutiérrez", "TGM"},
                {"Uruapan", "UPN"},
                {"Veracruz", "VER"},
                {"Villahermosa", "VSA"},
                {"Xalapa", "JAL"},
                {"Zacatecas", "ZCL"},
                {"Zamora", "ZMM"},
                {"Zapopan", "ZAP"},
                {"Zumpango", "SLM"},

                // ... Agrega el resto de los aeropuertos con sus claves IATA para Encode
            };//diccionario con Keys como aeropuertos y valores como clave iata

            Dictionary<string, string> decodeDictionary = new Dictionary<string, string>();
            
            foreach (var kvp in encodeDictionary)//diccionario con keys y datos invertidos
            {
                if (!decodeDictionary.ContainsKey(kvp.Value))
                {
                    decodeDictionary.Add(kvp.Value, kvp.Key);
                }
                else
                {
                    // Aquí puedes manejar duplicados si es necesario
                    // Por ejemplo, concatenar el valor adicional a la clave existente
                    // decodeDictionary[kvp.Value] += ", " + kvp.Key;
                }
            }


            while (true)
            {
                if (firstCond == true)
                {
                    Console.WriteLine("Opcion Encode:\nelige el aeropuerto para codificar en clave IATA\nRecuerda que el nombre debe comenzar en Mayuscula\ny deben llevar tilde");
                    string caseSwitchEnc = Console.ReadLine();
                    
                    if (encodeDictionary.TryGetValue(caseSwitchEnc, out string iataCode))
                    {
                        Console.WriteLine($"{iataCode}\n");
                    }
                    else
                    {
                        Console.WriteLine("Aeropuerto no encontrado");
                    }
                }
                else
                {
                    Console.WriteLine("Opcion Decode\nelige la clave aeroportuaria IATA para decodificar\nRecuerda que deben ir las tres letras en Mayuscula");
                    string caseSwitchDec = Console.ReadLine();

                    if (decodeDictionary.TryGetValue(caseSwitchDec, out string airportName))
                    {
                        Console.WriteLine($"{airportName}\n");
                    }
                    else
                    {
                        Console.WriteLine("Clave IATA no encontrada");
                    }
                }
            }
        }
    }
}
