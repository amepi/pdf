using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

// [ ] add QuestPDF license
// [ ] check if console reference is correct https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-console-app-to-the-solution
// [ ] publish package
// [ ] get data (ef core library?)
// [ ] create model for each document
// [ ] use previewver https://www.questpdf.com/document-previewer.html
// [ ] streamable response application/pdf https://github.com/QuestPDF/QuestPDF/issues/52#issuecomment-1235579574
// [ ] configure settings https://www.questpdf.com/concepts/document-settings.html#document-settings
// [ ] add unit test https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio?pivots=dotnet-7-0 
// [ ] how to test libraries https://learn.microsoft.com/en-us/dotnet/core/tutorials/libraries#how-to-test-libraries-on-net
// [ ] add readme file https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?toc=%2Fdotnet%2Ffundamentals%2Ftoc.json&bc=%2Fdotnet%2Fbreadcrumb%2Ftoc.json&tabs=netcore-cli#add-a-readme-or-another-file
// [ ] publish package privately https://learn.microsoft.com/en-us/nuget/hosting-packages/overview
// Examples https://github.com/QuestPDF/QuestPDF/tree/0a698c3d6eb7eb627b458ce1140de234eabeb020/Source/QuestPDF.Examples
// report sample https://github.com/QuestPDF/QuestPDF/tree/main/Source/QuestPDF.ReportSample
// .net class library https://learn.microsoft.com/en-us/dotnet/standard/class-libraries

namespace Amepi.Pdf
{
    public class Generator
    {
        private readonly IDocument _document;
        private readonly string _filePath;

        public Generator(IDocument document, string filePath)
        {
            _document = document;
            _filePath = filePath;
        }

        public void Generate()
        {
            _document.GeneratePdf(_filePath);
        }
    }
}