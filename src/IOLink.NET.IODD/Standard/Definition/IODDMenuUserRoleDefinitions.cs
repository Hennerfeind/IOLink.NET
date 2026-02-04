using System.Xml.Serialization;

namespace IOLink.NET.IODD.Standard.Definition.IODDMenuUserRoleDefinitions;

#if NETSTANDARD2_0

[XmlRoot(ElementName = "DocumentInfo")]
public class DocumentInfo
{

    [XmlAttribute(AttributeName = "version")]
    public string Version { get; set; }

    [XmlAttribute(AttributeName = "releaseDate")]
    public DateTime ReleaseDate { get; set; }

    [XmlAttribute(AttributeName = "copyright")]
    public string Copyright { get; set; }
}

[XmlRoot(ElementName = "Name")]
public class Name
{

    [XmlAttribute(AttributeName = "textId")]
    public string TextId { get; set; }
}

[XmlRoot(ElementName = "IdentificationMenu")]
public class IdentificationMenu
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "ParameterMenu")]
public class ParameterMenu
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "ObservationMenu")]
public class ObservationMenu
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "DiagnosisMenu")]
public class DiagnosisMenu
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "MenuHeaderCollection")]
public class MenuHeaderCollection
{

    [XmlElement(ElementName = "IdentificationMenu")]
    public IdentificationMenu IdentificationMenu { get; set; }

    [XmlElement(ElementName = "ParameterMenu")]
    public ParameterMenu ParameterMenu { get; set; }

    [XmlElement(ElementName = "ObservationMenu")]
    public ObservationMenu ObservationMenu { get; set; }

    [XmlElement(ElementName = "DiagnosisMenu")]
    public DiagnosisMenu DiagnosisMenu { get; set; }
}

[XmlRoot(ElementName = "ObserverRoleMenuSet")]
public class ObserverRoleMenuSet
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "MaintenanceRoleMenuSet")]
public class MaintenanceRoleMenuSet
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "SpecialistRoleMenuSet")]
public class SpecialistRoleMenuSet
{

    [XmlElement(ElementName = "Name")]
    public Name Name { get; set; }
}

[XmlRoot(ElementName = "UserRoleCollection")]
public class UserRoleCollection
{

    [XmlElement(ElementName = "ObserverRoleMenuSet")]
    public ObserverRoleMenuSet ObserverRoleMenuSet { get; set; }

    [XmlElement(ElementName = "MaintenanceRoleMenuSet")]
    public MaintenanceRoleMenuSet MaintenanceRoleMenuSet { get; set; }

    [XmlElement(ElementName = "SpecialistRoleMenuSet")]
    public SpecialistRoleMenuSet SpecialistRoleMenuSet { get; set; }
}

[XmlRoot(ElementName = "UserInterface")]
public class UserInterface
{

    [XmlElement(ElementName = "MenuHeaderCollection")]
    public MenuHeaderCollection MenuHeaderCollection { get; set; }

    [XmlElement(ElementName = "UserRoleCollection")]
    public UserRoleCollection UserRoleCollection { get; set; }
}

[XmlRoot(ElementName = "Text")]
public class Text
{

    [XmlAttribute(AttributeName = "id")]
    public string Id { get; set; }

    [XmlAttribute(AttributeName = "value")]
    public string Value { get; set; }
}

[XmlRoot(ElementName = "PrimaryLanguage")]
public class PrimaryLanguage
{

    [XmlElement(ElementName = "Text")]
    public List<Text> Text { get; set; }

    [XmlAttribute(AttributeName = "lang")]
    public string Lang { get; set; }
}

[XmlRoot(ElementName = "Language")]
public class Language
{

    [XmlElement(ElementName = "Text")]
    public List<Text> Text { get; set; }

    [XmlAttribute(AttributeName = "lang")]
    public string Lang { get; set; }
}

[XmlRoot(ElementName = "ExternalTextCollection")]
public class ExternalTextCollection
{

    [XmlElement(ElementName = "PrimaryLanguage")]
    public PrimaryLanguage PrimaryLanguage { get; set; }

    [XmlElement(ElementName = "Language")]
    public List<Language> Language { get; set; }
}

[XmlRoot(ElementName = "IODDMenuUserRoleDefinitions")]
public class IODDMenuUserRoleDefinitions
{

    [XmlElement(ElementName = "DocumentInfo")]
    public DocumentInfo DocumentInfo { get; set; }

    [XmlElement(ElementName = "UserInterface")]
    public UserInterface UserInterface { get; set; }

    [XmlElement(ElementName = "ExternalTextCollection")]
    public ExternalTextCollection ExternalTextCollection { get; set; }

    [XmlAttribute(AttributeName = "xsi")]
    public string Xsi { get; set; }
}

#else

[XmlRoot(ElementName = "DocumentInfo")]
public class DocumentInfo
{

    [XmlAttribute(AttributeName = "version")]
    public required string Version { get; set; }

    [XmlAttribute(AttributeName = "releaseDate")]
    public DateTime ReleaseDate { get; set; }

    [XmlAttribute(AttributeName = "copyright")]
    public required string Copyright { get; set; }
}

[XmlRoot(ElementName = "Name")]
public class Name
{

    [XmlAttribute(AttributeName = "textId")]
    public required string TextId { get; set; }
}

[XmlRoot(ElementName = "IdentificationMenu")]
public class IdentificationMenu
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "ParameterMenu")]
public class ParameterMenu
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "ObservationMenu")]
public class ObservationMenu
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "DiagnosisMenu")]
public class DiagnosisMenu
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "MenuHeaderCollection")]
public class MenuHeaderCollection
{

    [XmlElement(ElementName = "IdentificationMenu")]
    public required IdentificationMenu IdentificationMenu { get; set; }

    [XmlElement(ElementName = "ParameterMenu")]
    public required ParameterMenu ParameterMenu { get; set; }

    [XmlElement(ElementName = "ObservationMenu")]
    public required ObservationMenu ObservationMenu { get; set; }

    [XmlElement(ElementName = "DiagnosisMenu")]
    public required DiagnosisMenu DiagnosisMenu { get; set; }
}

[XmlRoot(ElementName = "ObserverRoleMenuSet")]
public class ObserverRoleMenuSet
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "MaintenanceRoleMenuSet")]
public class MaintenanceRoleMenuSet
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "SpecialistRoleMenuSet")]
public class SpecialistRoleMenuSet
{

    [XmlElement(ElementName = "Name")]
    public required Name Name { get; set; }
}

[XmlRoot(ElementName = "UserRoleCollection")]
public class UserRoleCollection
{

    [XmlElement(ElementName = "ObserverRoleMenuSet")]
    public required ObserverRoleMenuSet ObserverRoleMenuSet { get; set; }

    [XmlElement(ElementName = "MaintenanceRoleMenuSet")]
    public required MaintenanceRoleMenuSet MaintenanceRoleMenuSet { get; set; }

    [XmlElement(ElementName = "SpecialistRoleMenuSet")]
    public required SpecialistRoleMenuSet SpecialistRoleMenuSet { get; set; }
}

[XmlRoot(ElementName = "UserInterface")]
public class UserInterface
{

    [XmlElement(ElementName = "MenuHeaderCollection")]
    public required MenuHeaderCollection MenuHeaderCollection { get; set; }

    [XmlElement(ElementName = "UserRoleCollection")]
    public required UserRoleCollection UserRoleCollection { get; set; }
}

[XmlRoot(ElementName = "Text")]
public class Text
{

    [XmlAttribute(AttributeName = "id")]
    public required string Id { get; set; }

    [XmlAttribute(AttributeName = "value")]
    public required string Value { get; set; }
}

[XmlRoot(ElementName = "PrimaryLanguage")]
public class PrimaryLanguage
{

    [XmlElement(ElementName = "Text")]
    public required List<Text> Text { get; set; }

    [XmlAttribute(AttributeName = "lang")]
    public required string Lang { get; set; }
}

[XmlRoot(ElementName = "Language")]
public class Language
{

    [XmlElement(ElementName = "Text")]
    public required List<Text> Text { get; set; }

    [XmlAttribute(AttributeName = "lang")]
    public required string Lang { get; set; }
}

[XmlRoot(ElementName = "ExternalTextCollection")]
public class ExternalTextCollection
{

    [XmlElement(ElementName = "PrimaryLanguage")]
    public required PrimaryLanguage PrimaryLanguage { get; set; }

    [XmlElement(ElementName = "Language")]
    public required List<Language> Language { get; set; }
}

[XmlRoot(ElementName = "IODDMenuUserRoleDefinitions")]
public class IODDMenuUserRoleDefinitions
{

    [XmlElement(ElementName = "DocumentInfo")]
    public required DocumentInfo DocumentInfo { get; set; }

    [XmlElement(ElementName = "UserInterface")]
    public required UserInterface UserInterface { get; set; }

    [XmlElement(ElementName = "ExternalTextCollection")]
    public required ExternalTextCollection ExternalTextCollection { get; set; }

    [XmlAttribute(AttributeName = "xsi")]
    public required string Xsi { get; set; }
}

#endif
