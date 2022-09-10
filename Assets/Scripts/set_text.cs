using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_text : MonoBehaviour
{
    public Text txt;
    string The_American_Revolution = "The_American_Revolution";
    string The_Moon_Landing = "The_Moon_Landing";
    string Titanic = "Titanic";
    string American_Civil_War = "American_Civil_War";
    string Battle_of_the_Hydaspes = "Battle_of_the_Hydaspes";
    string Battle_of_Gallipoli = "Battle_of_Gallipoli";
    string battle_of_vienna_1683 = "battle_of_vienna_1683";
    string umayyad_conquest_of_spain = "umayyad_conquest_of_spain";
    string trojan_war = "trojan_war";
    string Siege_of_baghdad = "Siege_of_baghdad";
    string renassaince = "renassaince";
    string pearl_harbor = "pearl_harbor";

     void Start()
    {
        if (The_American_Revolution == GameManager.folder_name)
        {
            txt.text = "The American Revolution was a colonial revolt which occurred between 1765 and 1783. The American Patriots in the Thirteen Colonies defeated the British in the American Revolutionary War with the assistance of France, winning independence from Great Britain and establishing the United States of America.War didn't happen right away. First there were protests and arguments. Then some small skirmishes between the colonists and the local British army. Things just got worse and worse over the course of years until the colonies and Great Britain were at war.";
        }
        else if (The_Moon_Landing == GameManager.folder_name)
        {
            txt.text = "A Moon landing is the arrival of a spacecraft on the surface of the Moon. This includes both manned and robotic missions. The first human-made object to touch the Moon was the Soviet Union's Luna 2, on 13 September 1959. The United States' Apollo 11 was the first manned mission to land on the Moon, on 20 July 1969.The United States is the only country to have successfully conducted manned missions to the Moon, with the last departing the lunar surface in December 1972.";
        }
        else if (Titanic == GameManager.folder_name)
        {
            txt.text = "Designed to be the epitome of style and safety, the vessel featured many advanced luxury and safety features. Moreover, the ‘unsinkable’ RMS Titanic was commanded by a senior captain, 62-year-old Captain Edward Smith, again ensuring the safety of the vessel and its passengers.On 10 April 1912, when the largest ocean liner in service at that time, RMS Titanic, started its maiden voyage from Southampton, it was a new beginning in the history. ... On that fateful night, at around 11.40 PM Titanic struck an iceberg off the coast of Newfoundland and began to sink.";
        }
        else if (American_Civil_War == GameManager.folder_name)
        {
            txt.text = "The American Civil War was a civil war fought in the United States from 1861 to 1865, between the North and the South. The Civil War began primarily as a result of the long-standing controversy over the enslavement of black people.War broke out in April 1861 when secessionist forces attacked Fort Sumter in South Carolina shortly after Abraham Lincoln had been inaugurated as the President of the United States.";
        }
        else if (Battle_of_the_Hydaspes == GameManager.folder_name)
        {
            txt.text = "The Battle of the Hydaspes was fought in 326 BC between Alexander the Great and King Porus of the Paurava kingdom on the banks of the Jhelum River (known to the Greeks as Hydaspes) in the Punjab region of the Indian subcontinent (modern-day Punjab, Pakistan). The battle resulted in a Greek victory and the surrender of Porus. Large areas of the Punjab between the Hydaspes (Jhelum) and Hyphasis (Beas) rivers were absorbed into the Alexandrian Empire, and Porus was reinstated as a subordinate ruler.";
        }
        else if (Battle_of_Gallipoli == GameManager.folder_name)
        {
            txt.text = "The Gallipoli campaign, also known as the Dardanelles campaign, the Battle of Gallipoli or the Battle of Çanakkale , was a campaign of the First World War that took place on the Gallipoli peninsula (Gelibolu in modern Turkey), from 17 February 1915 to 9 January 1916. The Entente powers, Britain, France and the Russian Empire, sought to weaken the Ottoman Empire, one of the Central Powers, by taking control of the straits that provided a supply route to Russia. The Allies' attack on Ottoman forts at the entrance of the Dardanelles in February 1915 failed and was followed by an amphibious landing on the Gallipoli peninsula in April 1915 to capture the Ottoman capital of Constantinople (Istanbul).";
        }
        else if (battle_of_vienna_1683 == GameManager.folder_name)
        {
            txt.text = "The Battle of Vienna took place at Kahlenberg Mountain near Vienna on 12 September 1683 after the imperial city had been besieged by the Ottoman Empire for two months. The battle was fought by the Habsburg Monarchy, the Polish–Lithuanian Commonwealth and the Holy Roman Empire, under the command of King John III Sobieski against the Ottomans and their vassal and tributary states. The battle marked the first time the Commonwealth and the Holy Roman Empire had cooperated militarily against the Ottomans, and it is often seen as a turning point in history, after which the Ottoman Turks ceased to be a menace to the Christian world.";
        }
        else if (umayyad_conquest_of_spain == GameManager.folder_name)
        {
            txt.text = "The Umayyad conquest of Hispania, also known as the Muslim conquest of the Iberian Peninsula or the Umayyad conquest of the Visigothic Kingdom, was the initial expansion of the Umayyad Caliphate over Hispania (in the Iberian Peninsula) from 711 to 788. The conquest resulted in the destruction of the Visigothic Kingdom and the establishment of the independent Emirate of Córdoba under Abd ar-Rahman I (ruled 756–788), who completed the unification of the Muslim-ruled areas (known as al-Andalus). The conquest marks the westernmost expansion of both the Umayyad Caliphate and Muslim rule into Europe.";
        }
        else if (trojan_war == GameManager.folder_name)
        {
            txt.text = "In Greek mythology, the Trojan War was waged against the city of Troy by the Achaeans (Greeks) after Paris of Troy took Helen from her husband Menelaus, king of Sparta. The war is one of the most important events in Greek mythology and has been narrated through many works of Greek literature, most notably Homer's Iliad. The core of the Iliad (Books II – XXIII) describes a period of four days and two nights in the tenth year of the decade-long siege of Troy; the Odyssey describes the journey home of Odysseus, one of the war's heroes.";
        }
        else if (Siege_of_baghdad == GameManager.folder_name)
        {
            txt.text = "The Siege of Baghdad, which lasted from January 29 until February 10, 1258, entailed the investment, capture, and sack of Baghdad, the capital of the Abbasid Caliphate, by Ilkhanate Mongol forces and allied troops. The Mongols were under the command of Hulagu Khan (or Hulegu Khan), brother of the khagan Möngke Khan, who had intended to further extend his rule into Mesopotamia but not to directly overthrow the Caliphate. Möngke, however, had instructed Hulagu to attack Baghdad if the Caliph Al-Musta'sim refused Mongol demands for his continued submission to the khagan and the payment of tribute in the form of military support for Mongol forces in Persia.";
        }
        else if (renassaince == GameManager.folder_name)
        {
            txt.text = "The Renaissance was a period in European history marking the transition from the Middle Ages to Modernity and covering the 15th and 16th centuries. In addition to the standard periodization, proponents of a long Renaissance put its beginning in the 14th century and its end in the 17th century. The traditional view focuses more on the early modern aspects of the Renaissance and argues that it was a break from the past, but many historians today focus more on its medieval aspects and argue that it was an extension of the Middle Ages.";
        }
        else if (pearl_harbor == GameManager.folder_name)
        {
            txt.text = "The attack on Pearl Harbor was a surprise preemptive military strike by the Imperial Japanese Navy Air Service upon the United States (a neutral country at the time) against the naval base at Pearl Harbor in Honolulu, Hawaii on Sunday morning, December 7, 1941. The attack led to the United States' formal entry into World War II the next day. The Japanese military leadership referred to the attack as the Hawaii Operation and Operation AI, and as Operation Z during its planning.";
        }
    }
}
