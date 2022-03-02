namespace StreamingContentRepo;
public class StreamingContent
{
public string Title{get; set;}
public string Description {get; set;}
public double StarRating {get; set;}
public MaturityRating MaturityRating {get; set;}
public bool IsFamilyFriendly {get {
switch(MaturityRating){
    case MaturityRating.G:
    case MaturityRating.PG:
    case MaturityRating.TV_Y:
    case MaturityRating.TV_G:
    case MaturityRating.TV_PG:
    return true;
    case MaturityRating.PG_13:
    case MaturityRating.R:
    case MaturityRating.NC_17:
    case MaturityRating.TV_14:
    case MaturityRating.TV_MA:
    return false;
}
if((int)MaturityRating > 4){
    return false;
}
else{
    return true;
}
}}

public GenreType TypeOfGenre {get; set;}

public StreamingContent(){}
public StreamingContent(string title, string description, MaturityRating maturityRating, double starRating,GenreType genreType){
    Title = title;
    Description = description;
    MaturityRating = maturityRating;
    StarRating = starRating;
    TypeOfGenre = genreType;
    
}
}

public enum GenreType{
    Horror = 1,
    Comedy,
    Drama,
    Gore,
    Mystery,
    Action
}
public enum MaturityRating{
    G,
    PG,
    PG_13,
    R,
    NC_17,
    TV_Y,
    TV_G,
    TV_PG,
    TV_14,
    TV_MA
}
