Shader "UFZ/Transparent-SolidColor-Lit-Back" {
	Properties {
		_Color ("Main Color", Color) = (1,1,1,1)
	}
	SubShader {
		Tags {"RenderType"="Transparent" "Queue"="Transparent" "IgnoreProjector"="True"}
		Blend SrcAlpha OneMinusSrcAlpha
		Cull Front
		LOD 200

		CGPROGRAM
		#pragma surface surf Lambert alpha vertex:vert

		float4 _Color;

		struct Input {
			float2 uv_MainTex;
		};

		void vert (inout appdata_full v, out Input o) {
			UNITY_INITIALIZE_OUTPUT(Input, o);
			v.normal = -v.normal;
		}

		void surf(Input IN, inout SurfaceOutput o) {
			half4 c = _Color;
			o.Albedo = c.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
	FallBack "Transparent/Diffuse"
}
