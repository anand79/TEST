using MDM.Server.DataService;
using MDM.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Net;

namespace MDM.Server.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]    
    public class SongController : ControllerBase
    {

        private readonly ILogger<SongController> _logger;

        public SongController(ILogger<SongController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetSongs")]
        public async Task<IActionResult> GetSongs()
        {
            try
            {
                var songList = new List<Song>();                
                //user name for logging into system
                string userNmae = User.Identity.Name;
                await Task.Run(() =>
                {
                    _logger.LogInformation("Getting Song detail");
                    songList = DBHelper.GetSongs();
                });                
                return Ok(songList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                
                _logger.LogCritical(ex, ex.Message);
                return BadRequest(ex.Message);
            }

            
        }

        [HttpPost]
        [Route("SaveSong")]
        public async Task<IActionResult> SaveSong([FromBody] Song songData)
        {
            try
            {
                await Task.Run(() =>
                {
                    _logger.Log(LogLevel.Information, "saving data to backend");
                });
                return Ok("Saved information!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                _logger.LogCritical(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete()]
        [Route("DeleteSong")]
        public IActionResult DeleteSong(int id)
        {
            try
            {
                var song = DBHelper.FindSongById(id);
                if (song == null)
                    return NotFound();

                DBHelper.DeleteSong(id); // Assume this deletes the song.
                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
