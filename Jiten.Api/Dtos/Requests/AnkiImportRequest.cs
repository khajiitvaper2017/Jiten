using Jiten.Core.Data.FSRS;

namespace Jiten.Api.Dtos.Requests;

public class AnkiImportRequest
{
    public List<AnkiCardWrapper> Cards { get; set; } = new();
}

public class AnkiCardWrapper
{
    public FsrsCard Card { get; set; }
    public List<FsrsReviewLog> ReviewLogs { get; set; } = new();
}