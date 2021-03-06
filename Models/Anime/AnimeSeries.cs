﻿using AnimeListings.Models.Anime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AnimeListings.Models
{
    public class AnimeSeries
    {
        public int Id { get; set; }

        public string EnglishTitle { get; set; }

        public string JapaneseName { get; set; }

        public string Type { get; set; }

        [Display(Name = "Air Date")]
        [Column(TypeName = "Date")]//converts to short time 'MM/DD/YYYY'
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Finish Date")]
        [Column(TypeName = "Date")]//converts to short time 'MM/DD/YYYY'
        public DateTime FinishDate { get; set; }

        public string Synopsis { get; set; }

        public AnimeSeriesPictures Picture { get; set; }

        //IList allows more functionality than ICollection, but more expensive and allows Order by Id
        public List<SeasonsEpisodes> SeasonsEpisodes { get; set; } = new List<SeasonsEpisodes>();

        public AnimeSeries ToModel(AnimeSeries series)
        {
            return new AnimeSeries{
                EnglishTitle = series.EnglishTitle,
                FinishDate =  series.FinishDate,
                JapaneseName = series.JapaneseName,
                Picture = series.Picture,
                ReleaseDate = series.ReleaseDate,
                SeasonsEpisodes = series.SeasonsEpisodes,
                Synopsis = series.Synopsis,
                Type = series.Type
            };
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
