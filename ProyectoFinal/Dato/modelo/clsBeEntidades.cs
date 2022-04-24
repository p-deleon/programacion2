public class clsBeEntidades : ICloneable {

	private int mIdEntidad = 0;
	private string mDescripcion = '';
	private string mDireccion = '';
	private string mLocalidad = '';
	private string mTipoEntidad = '';
	private string mTipoDocumento = '';
	private double mNumeroDocumento = 0.0;
	private string mTelefonos = '';
	private string mURLPaginaWeb = '';
	private string mURLFacebook = '';
	private string mURLInstagram = '';
	private string mURLTwitter = '';
	private string mURLTikTok = '';
	private int mIdGrupoEntidad = 0;
	private int mIdTipoEntidad = 0;
	private int mLimiteCredito = 0;
	private string mUserNameEntidad = '';
	private string mPasswordEntidad = '';
	private string mRolUserEntidad = '';
	private string mComentario = '';
	private string mEstatus = '';
	private bool mNoEliminable = False;
	private String mFechaRegistro = ;

	public Integer IdEntidad {
		get {
			return mIdEntidad;
		}
		set {
			mIdEntidad = value;
		}
	}

	public String Descripcion {
		get {
			return mDescripcion;
		}
		set {
			mDescripcion = value;
		}
	}

	public String Direccion {
		get {
			return mDireccion;
		}
		set {
			mDireccion = value;
		}
	}

	public String Localidad {
		get {
			return mLocalidad;
		}
		set {
			mLocalidad = value;
		}
	}

	public String TipoEntidad {
		get {
			return mTipoEntidad;
		}
		set {
			mTipoEntidad = value;
		}
	}

	public String TipoDocumento {
		get {
			return mTipoDocumento;
		}
		set {
			mTipoDocumento = value;
		}
	}

	public Double NumeroDocumento {
		get {
			return mNumeroDocumento;
		}
		set {
			mNumeroDocumento = value;
		}
	}

	public String Telefonos {
		get {
			return mTelefonos;
		}
		set {
			mTelefonos = value;
		}
	}

	public String URLPaginaWeb {
		get {
			return mURLPaginaWeb;
		}
		set {
			mURLPaginaWeb = value;
		}
	}

	public String URLFacebook {
		get {
			return mURLFacebook;
		}
		set {
			mURLFacebook = value;
		}
	}

	public String URLInstagram {
		get {
			return mURLInstagram;
		}
		set {
			mURLInstagram = value;
		}
	}

	public String URLTwitter {
		get {
			return mURLTwitter;
		}
		set {
			mURLTwitter = value;
		}
	}

	public String URLTikTok {
		get {
			return mURLTikTok;
		}
		set {
			mURLTikTok = value;
		}
	}

	public Integer IdGrupoEntidad {
		get {
			return mIdGrupoEntidad;
		}
		set {
			mIdGrupoEntidad = value;
		}
	}

	public Integer IdTipoEntidad {
		get {
			return mIdTipoEntidad;
		}
		set {
			mIdTipoEntidad = value;
		}
	}

	public Integer LimiteCredito {
		get {
			return mLimiteCredito;
		}
		set {
			mLimiteCredito = value;
		}
	}

	public String UserNameEntidad {
		get {
			return mUserNameEntidad;
		}
		set {
			mUserNameEntidad = value;
		}
	}

	public String PasswordEntidad {
		get {
			return mPasswordEntidad;
		}
		set {
			mPasswordEntidad = value;
		}
	}

	public String RolUserEntidad {
		get {
			return mRolUserEntidad;
		}
		set {
			mRolUserEntidad = value;
		}
	}

	public String Comentario {
		get {
			return mComentario;
		}
		set {
			mComentario = value;
		}
	}

	public String Estatus {
		get {
			return mEstatus;
		}
		set {
			mEstatus = value;
		}
	}

	public Boolean NoEliminable {
		get {
			return mNoEliminable;
		}
		set {
			mNoEliminable = value;
		}
	}

	public String FechaRegistro {
		get {
			return mFechaRegistro;
		}
		set {
			mFechaRegistro = value;
		}
	}

	Entidades(){
	}

	Entidades(){ref int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, double NumeroDocumento, string Telefonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, int IdGrupoEntidad, int IdTipoEntidad, int LimiteCredito, string UserNameEntidad, string PasswordEntidad, string RolUserEntidad, string Comentario, string Estatus, bool NoEliminable, String FechaRegistro)
		mIdEntidad = IdEntidad;
		mDescripcion = Descripcion;
		mDireccion = Direccion;
		mLocalidad = Localidad;
		mTipoEntidad = TipoEntidad;
		mTipoDocumento = TipoDocumento;
		mNumeroDocumento = NumeroDocumento;
		mTelefonos = Telefonos;
		mURLPaginaWeb = URLPaginaWeb;
		mURLFacebook = URLFacebook;
		mURLInstagram = URLInstagram;
		mURLTwitter = URLTwitter;
		mURLTikTok = URLTikTok;
		mIdGrupoEntidad = IdGrupoEntidad;
		mIdTipoEntidad = IdTipoEntidad;
		mLimiteCredito = LimiteCredito;
		mUserNameEntidad = UserNameEntidad;
		mPasswordEntidad = PasswordEntidad;
		mRolUserEntidad = RolUserEntidad;
		mComentario = Comentario;
		mEstatus = Estatus;
		mNoEliminable = NoEliminable;
		mFechaRegistro = FechaRegistro;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
