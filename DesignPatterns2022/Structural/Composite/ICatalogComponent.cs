using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Composite
{
    // Soyut yapımızdır.
    // Diğer istemci sınıflar bu yapıyı uygular.
    // Diğer sınıfların uygulayacağı hiyerarşiyi çizme metotunu içermektedir.
    public interface ICatalogComponent
    {
        void DrawHierarchy();
    }
}
