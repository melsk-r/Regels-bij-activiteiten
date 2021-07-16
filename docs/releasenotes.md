---
layout: page-with-side-nav
title: Releasenotes
---

# Release notes Regels bij Activiteiten API

## Versie 1.0.0 (16-07-2021)

  Naast de wijzigingen i.v.m. de issues in de volgende sectie zijn er ook nog enkele andere wijzigingen aangebracht.
  
  - Alle informatie m.b.t. bestandsuitwisseling is nu verzameld in de README op root niveau.
  - Alle identificatie attributes verwijzen nu naar het component 'Identificatie' of 'WId'.
  - De vorm van het 'geometrie' attribute zo aangepast dat het ook de omschrijving daarvan bevat. 
    Hetzelfde geldt voor de attributes 'groep', 'idealisatie', 'activiteitregelkwalificatie' en 'type' binnen resp. 
	'Activiteit', 'JuridischeRegelVoorIedereen', 'ActiviteitLocatieaanduiding' en 'Omgevingsdocument'.
  - Ook de query parameters 'inclusiefVervallen', 'omgevingsdocumentIdentificatie' en 'werkpakketCode' zijn nu
    lowerCamelCase waardoor parameternamen waar van toepassing gelijk zijn aan de gereleateerde attributes.
  

### Opgeloste issues
  Alle issues die in deze release zijn opgelost hebben in de issues-lijst het label "1.0" gekregen. Door op dit label te filteren in de (gesloten) issues is een gedetailleerd overzicht van wijzigingen en bug-fixes te krijgen.
  Hieronder is per issue beschreven welke wijzigingen daravoor zijn aangebracht.

  | Link Github	| Beschrijving |
  | --- | --- |
  | #36 | Fout in waarde van description van het property 'werkpakketCode' in 'regeltekst' is gefixed. |
  | #37 | Attribute 'werkpakketCode' is verwijderd uit 'Locatie'. |
  | #38 | Conflicterende karakters uit de description van relatie 'is' op 'activiteit' zijn verwijderd. |
  | #39 | De 'url' waarden van de server beschrijving bovenin de specificatie is gecorrigeerd. |
  | #40 | De 'title' property in het info deel van de specificatie is gecorrigeerd. |
  | #41 | De property 'documentType' in 'Omgevingsdocument' is verplicht gemaakt en hernoemd naar 'type'. |
  | #42 | De property 'documentType' in 'Omgevingsdocument' is verplicht gemaakt en hernoemd naar 'type'. |
  | #43 | De omschrijving van een groot aantal componenten is verbeterd. |
  | #44 | Conflicterend karakter uit de description van relatie 'gerelateerd' op 'activiteit' is verwijderd. |
  | #45 | De vreemde 'description' op component 'locatieType' is verwijderd. |
  | #46 | De omschrijving van een groot aantal componenten is verbeterd. |

## Versie 1.0.0-rc1 (30-04-2021)

  Hieronder staan de endpoints die in deze standaard gedefinieerd zijn. Verdere details staan in de specificatie.
  -	/activiteiten
  -	/activiteiten/{identificatie}
  -	/juridischeregelsvooriedereen
  -	/juridischeregelsvooriedereen/{identificatie}
  -	/locaties
  -	/locaties/{identificatie}
  -	/regelteksten
  -	/regelteksten/{identificatie}

### Known issues
  De volgende issues staan nog open, oplossing volgt in een latere versie:

  | Link Github	| Beschrijving |
  | --- | --- | --- |

