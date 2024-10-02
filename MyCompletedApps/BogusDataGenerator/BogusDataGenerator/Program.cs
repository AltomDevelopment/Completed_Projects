using Bogus;
using Bogus.DataSets;
using MVC_Template.Models;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

class Program
{
    //Uncomment the dataType that you need and hit run and 25 pieces of data will be created 
    static void Main(string[] args)
    {
        List<string> JsonList = new List<string>();

        int numberOfItemsToCreate = 0;

        while (numberOfItemsToCreate < 25)
        {
            var createdFaker = new Faker<BogusDataModel>()
            //.RuleFor(e => e.ModelZipCode, f => f.Address.ZipCode())
            //.RuleFor(e => e.ModelCity, f => f.Address.City())
            //.RuleFor(e => e.ModelCityPrefix, f => f.Address.CityPrefix())
            //.RuleFor(e => e.ModelCitySuffix, f => f.Address.CitySuffix())
            //.RuleFor(e => e.ModelStreetName, f => f.Address.StreetName())
            //.RuleFor(e => e.ModelBuildingNumber, f => f.Address.BuildingNumber())
            //.RuleFor(e => e.ModelStreetSuffix, f => f.Address.StreetSuffix())
            //.RuleFor(e => e.ModelSecondaryAddress, f => f.Address.SecondaryAddress())
            //.RuleFor(e => e.ModelCounty, f => f.Address.County())
            //.RuleFor(e => e.ModelCountry, f => f.Address.Country())
            //.RuleFor(e => e.ModelFullAddress, f => f.Address.FullAddress())
            //.RuleFor(e => e.ModelCountryCode, f => f.Address.CountryCode())
            //.RuleFor(e => e.ModelState, f => f.Address.State())
            //.RuleFor(e => e.ModelStateAbbr, f => f.Address.StateAbbr())
            //.RuleFor(e => e.ModelDepartment, f => f.Commerce.Department())
            //.RuleFor(e => e.ModelPrice, f => f.Commerce.Price())
            //.RuleFor(e => e.ModelProductName, f => f.Commerce.ProductName())
            //.RuleFor(e => e.ModelProduct, f => f.Commerce.Product())
            //.RuleFor(e => e.ModelProductAdjective, f => f.Commerce.ProductAdjective())
            //.RuleFor(e => e.ModelProductMaterial, f => f.Commerce.ProductMaterial())
            //.RuleFor(e => e.ModelEan8, f => f.Commerce.Ean8())
            //.RuleFor(e => e.ModelEan13, f => f.Commerce.Ean13())
            //.RuleFor(e => e.ModelCompanySuffix, f => f.Company.CompanySuffix())
            //.RuleFor(e => e.ModelCompanyName, f => f.Company.CompanyName())
            //.RuleFor(e => e.ModelCatchPhrase, f => f.Company.CatchPhrase())
            //.RuleFor(e => e.ModelBs, f => f.Company.Bs())
            //.RuleFor(e => e.ModelColumn, f => f.Database.Column())
            //.RuleFor(e => e.ModelType, f => f.Database.Type())
            //.RuleFor(e => e.ModelCollation, f => f.Database.Collation())
            //.RuleFor(e => e.ModelEngine, f => f.Database.Engine())
            //.RuleFor(e => e.ModelMonth, f => f.Date.Month())
            //.RuleFor(e => e.ModelWeekday, f => f.Date.Weekday())
            //.RuleFor(e => e.ModelAccount, f => f.Address.City())
            //.RuleFor(e => e.ModelAccountName, f => f.Finance.AccountName())
            //.RuleFor(e => e.ModelTransactionType, f => f.Finance.TransactionType())
            //.RuleFor(e => e.ModelCreditCardNumber, f => f.Finance.CreditCardNumber())
            //.RuleFor(e => e.ModelCreditCardCvv, f => f.Finance.CreditCardCvv())
            //.RuleFor(e => e.ModelBitcoinAddress, f => f.Finance.BitcoinAddress())
            //.RuleFor(e => e.ModelEthereumAddress, f => f.Finance.EthereumAddress())
            //.RuleFor(e => e.ModelRoutingNumber, f => f.Finance.RoutingNumber())
            //.RuleFor(e => e.ModelBic, f => f.Finance.Bic())
            //.RuleFor(e => e.ModelIban, f => f.Finance.Iban())
            //.RuleFor(e => e.ModelAbbreviation, f => f.Hacker.Abbreviation())
            //.RuleFor(e => e.ModelAdjective, f => f.Hacker.Adjective())
            //.RuleFor(e => e.ModelNoun, f => f.Hacker.Noun())
            //.RuleFor(e => e.ModelVerb, f => f.Hacker.Verb())
            //.RuleFor(e => e.ModelIngVerb, f => f.Hacker.IngVerb())
            //.RuleFor(e => e.ModelAvatar, f => f.Internet.Avatar())
            //.RuleFor(e => e.ModelEmail, f => f.Internet.Email())
            //.RuleFor(e => e.ModelExampleEmail, f => f.Internet.ExampleEmail())
            //.RuleFor(e => e.ModelUserName, f => f.Internet.UserName())
            //.RuleFor(e => e.ModelUserNameUnicode, f => f.Internet.UserNameUnicode())
            //.RuleFor(e => e.ModelDomainName, f => f.Internet.DomainName())
            //.RuleFor(e => e.ModelDomainWord, f => f.Internet.DomainWord())
            //.RuleFor(e => e.ModelDomainSuffix, f => f.Internet.DomainSuffix())
            //.RuleFor(e => e.ModelIp, f => f.Internet.Ip())
            //.RuleFor(e => e.ModelUserAgent, f => f.Internet.UserAgent())
            //.RuleFor(e => e.ModelMac, f => f.Internet.Mac())
            //.RuleFor(e => e.ModelPassword, f => f.Internet.Password())
            //.RuleFor(e => e.ModelColor, f => f.Internet.Color())
            //.RuleFor(e => e.ModelProtocol, f => f.Internet.Protocol())
            //.RuleFor(e => e.ModelUrl, f => f.Internet.Url())
            //.RuleFor(e => e.ModelUrlWithPath, f => f.Internet.UrlWithPath())
            //.RuleFor(e => e.ModelUrlRootedPath, f => f.Internet.UrlRootedPath())
            //.RuleFor(e => e.ModelWord, f => f.Lorem.Word())
            //.RuleFor(e => e.ModelLetter, f => f.Lorem.Letter())
            //.RuleFor(e => e.ModelSentence, f => f.Lorem.Sentence())
            //.RuleFor(e => e.ModelSentences, f => f.Lorem.Sentences())
            //.RuleFor(e => e.ModelParagraph, f => f.Lorem.Paragraph())
            //.RuleFor(e => e.ModelText, f => f.Lorem.Text())
            //.RuleFor(e => e.ModelSlug, f => f.Lorem.Slug())
            //.RuleFor(e => e.ModelFirstName, f => f.Name.FirstName())
            //.RuleFor(e => e.ModelLastName, f => f.Name.LastName())
            //.RuleFor(e => e.ModelFullName, f => f.Name.FullName())
            //.RuleFor(e => e.ModelPrefix, f => f.Name.Prefix())
            //.RuleFor(e => e.ModelSuffix, f => f.Name.Suffix())
            //.RuleFor(e => e.ModelFindName, f => f.Name.FindName())
            //.RuleFor(e => e.ModelJobTitle, f => f.Name.JobTitle())
            //.RuleFor(e => e.ModelJobDescriptor, f => f.Name.JobDescriptor())
            //.RuleFor(e => e.ModelJobArea, f => f.Name.JobArea())
            //.RuleFor(e => e.ModelJobType, f => f.Name.JobType())
            //.RuleFor(e => e.ModelPhoneNumber, f => f.Phone.PhoneNumber())
            //.RuleFor(e => e.ModelPhoneNumberFormat, f => f.Phone.PhoneNumberFormat())
            //.RuleFor(e => e.ModelReview, f => f.Rant.Review())
            //.RuleFor(e => e.ModelFileName, f => f.System.FileName())
            //.RuleFor(e => e.ModelDirectoryPath, f => f.System.DirectoryPath())
            //.RuleFor(e => e.ModelFilePath, f => f.System.FilePath())
            //.RuleFor(e => e.ModelCommonFileName, f => f.System.CommonFileName())
            //.RuleFor(e => e.ModelMimeType, f => f.System.MimeType())
            //.RuleFor(e => e.ModelCommonFileType, f => f.System.CommonFileType())
            //.RuleFor(e => e.ModelCommonFileExt, f => f.System.CommonFileExt())
            //.RuleFor(e => e.ModelFileType, f => f.System.FileType())
            //.RuleFor(e => e.ModelFileExt, f => f.System.FileExt())
            //.RuleFor(e => e.ModelSemver, f => f.System.Semver())
            //.RuleFor(e => e.ModelVin, f => f.Vehicle.Vin())
            //.RuleFor(e => e.ModelManufacturer, f => f.Vehicle.Manufacturer())
            //.RuleFor(e => e.ModelModel, f => f.Vehicle.Model())
            //.RuleFor(e => e.ModelType, f => f.Vehicle.Type())
            //.RuleFor(e => e.ModelFuel, f => f.Vehicle.Fuel())
            //.RuleFor(e => e.ModelHash, f => f.Random.Hash());

            string JsonItems = JsonSerializer.Serialize(createdFaker.Generate());
            JsonList.Add(JsonItems);
            numberOfItemsToCreate++;
        }
        
        foreach( var item in JsonList )
        {
            string[] text = item.Split(",");
            if (text.Contains(":null") != true)
            {
                foreach (string jsontext in text)
                {
                    if (jsontext.Contains(":null") != true)
                    {
                        Console.WriteLine(jsontext);
                    }
                }
            }
        }
    }
}






