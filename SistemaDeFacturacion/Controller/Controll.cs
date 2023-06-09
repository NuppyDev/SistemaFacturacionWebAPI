using Newtonsoft.Json;
using WebAPI.Models.Dto.Base;

namespace Controller
{
    public class ControlMesas
    {
        public async void ObtenerMesasYMeseros(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(String.Format("{0}/{1}", "https://localhost:7051/api/Tables", id));
                if (response.IsSuccessStatusCode)
                {
                    var tables = await response.Content.ReadAsStringAsync();
                    StudentDto studentDto = JsonConvert.DeserializeObject<TablesDto>(student);
                    txtStudentId.Text = studentDto.StudentId.ToString();
                    txtStudentName.Text = studentDto.StudentName;
                    cbGrados.SelectedIndex = (1 - studentDto.GradeId);
                    dtpFechaNacimiento.Value = studentDto.DateOfBirth;
                }
                else
                {
                    MessageBox.Show($"No se puede obtener el estudiante: {response.StatusCode}");
                }
            }
        }
    }
}