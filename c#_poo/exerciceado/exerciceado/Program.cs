using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using exerciceado.classes.model;
using exerciceado.classes.repository;
using MySql.Data.MySqlClient;

EtudiantRepository pRepo = new EtudiantRepository();
pRepo.CreateTableEtudiant();
pRepo.AjouterUnEtudiant(new Etudiant(null, "cap", "fred", " 26_07_1971", "test3@test.com"));
pRepo.ModifierUnEtudiant(new Etudiant(1, "Toto", "Tata", " 20_06_1972", "toto@tata.com"));
pRepo.SupprimerUnEtudiant(2);



List<Etudiant> etudiant = pRepo.AfficherToutLesEtudiant();
foreach (Etudiant Etudiant in etudiant)
{
    Console.WriteLine(etudiant);
}

Console.WriteLine(pRepo.AfficherUnEtudiantParSonId(1));
